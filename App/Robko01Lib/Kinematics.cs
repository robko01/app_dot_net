/*

Copyright (c) [2016] [Orlin Dimitrov]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

using System;

namespace Robko01Lib
{
    public class Kinematics
    {

        #region Constants

        private const int H_mm = 190;
        private const int L_mm = 178;
        private const int LL_mm = 92;
        
        private const double S1 = 1222.7;
        private const double S2 = 1161.4;
        private const double S3 = 680.1;
        private const double S4 = 244.7;
        private const double S5 = 244.7;
        private const double S6 = 27;

        #endregion

        #region Variables

        private double pRad, rRad, theta1Rad, theta2Rad, theta3Rad, theta4Rad, theta5Rad;
        private double RR_mm;
        private double tht1_rad_new, tht2_rad_new, tht3_rad_new, tht4_rad_new, tht5_rad_new;

        private double theta1;
        private double theta2;
        private double theta3;
        private double theta4;
        private double theta5;

        private double xmm;
        private double ymm;
        private double zmm;
        private double pdeg;
        private double rdeg;

        /// <summary>
        /// Absolute roll.
        /// </summary>
        public bool AbsoluteRoll = true;

        private object syncCalculations = new object();

        #endregion

        #region Properties

        #region Angles

        /// <summary>
        /// Theta 1 [deg]
        /// </summary>
        public double Theta1
        {
            set
            {
                this.theta1 = value;
                this.ForwardKinematics();
            }
            get
            {
                return this.theta1;
            }
        }

        /// <summary>
        /// Theta 2 [deg]
        /// </summary>
        public double Theta2
        {
            set
            {
                this.theta2 = value;
                this.ForwardKinematics();
            }
            get
            {
                return this.theta2;
            }
        }

        /// <summary>
        /// Theta 3 [deg]
        /// </summary>
        public double Theta3
        {
            set
            {
                this.theta3 = value;
                this.ForwardKinematics();
            }
            get
            {
                return this.theta3;
            }
        }

        /// <summary>
        /// Theta 4 [deg]
        /// </summary>
        public double Theta4
        {
            set
            {
                this.theta4 = value;
                this.ForwardKinematics();
            }
            get
            {
                return this.theta4;
            }
        }

        /// <summary>
        /// Theta 5 [deg]
        /// </summary>
        public double Theta5
        {
            set
            {
                this.theta5 = value;
                this.ForwardKinematics();
            }
            get
            {
                return this.theta5;
            }
        }

        #endregion

        #region XYZPR

        /// <summary>
        /// X axis [mm]
        /// </summary>
        public double Xmm
        {
            set
            {
                this.xmm = value;
                this.InverseKinematics(this.AbsoluteRoll);
            }
            get
            {
                return this.xmm;
            }
        }

        /// <summary>
        /// Y axis [mm]
        /// </summary>
        public double Ymm
        {
            set
            {
                this.ymm = value;
                this.InverseKinematics(this.AbsoluteRoll);
            }
            get
            {
                return this.ymm;
            }
        }

        /// <summary>
        /// Z axis [mm]
        /// </summary>
        public double Zmm
        {
            set
            {
                this.zmm = value;
                this.InverseKinematics(this.AbsoluteRoll);
            }
            get
            {
                return this.zmm;
            }
        }

        /// <summary>
        /// P axis [deg]
        /// </summary>
        public double Pdeg
        {
            set
            {
                this.pdeg = value;
                this.InverseKinematics(this.AbsoluteRoll);
            }
            get
            {
                return this.pdeg;
            }
        }

        /// <summary>
        /// R axis [deg]
        /// </summary>
        public double Rdeg
        {
            set
            {
                this.rdeg = value;
                this.InverseKinematics(this.AbsoluteRoll);
            }
            get
            {
                return this.rdeg;
            }
        }

        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Kinematics()
        {
            // Initial values.
            this.theta1 = 0.0d;
            this.theta2 = -25.0d;
            this.theta3 = -25.0d;
            this.theta4 = 65.0d;
            this.theta5 = 65.0d;

            // Preset initial.
            this.pRad = Kinematics.DegToRad(65.0d);
            this.rRad = 0.0d;
            this.theta1Rad = 0.0d;
            this.theta2Rad = Kinematics.DegToRad(this.theta2);
            this.theta3Rad = Kinematics.DegToRad(this.theta3);
            this.theta4Rad = Kinematics.DegToRad(this.theta4);
            this.theta5Rad = Kinematics.DegToRad(this.theta5);

            this.tht1_rad_new = 0.0d;
            this.tht2_rad_new = 0.0d;
            this.tht3_rad_new = 0.0d;
            this.tht4_rad_new = 0.0d;
            this.tht5_rad_new = 0.0d;

            this.xmm = 361;
            this.ymm = 0;
            this.zmm = 122;
        }

        #endregion

        #region Public Methods

        public int[] GoForward()
        {
            int[] steps = new int[5];

            //TODO: Check does it need a second recalculation.
            this.ForwardKinematics();

            steps[0] = (int)Math.Round((this.tht1_rad_new - this.theta1Rad) * S1, 0);
            steps[1] = (int)Math.Round((this.tht2_rad_new - this.theta2Rad) * S2, 0);
            steps[2] = (int)Math.Round((this.tht3_rad_new - this.theta3Rad) * S3, 0);
            steps[3] = (int)Math.Round((this.tht4_rad_new - this.theta4Rad) * S4, 0);
            steps[4] = (int)Math.Round((this.tht5_rad_new - this.theta5Rad) * S5, 0);

            this.theta1Rad = this.tht1_rad_new;
            this.theta2Rad = this.tht2_rad_new;
            this.theta3Rad = this.tht3_rad_new;
            this.theta4Rad = this.tht4_rad_new;
            this.theta5Rad = this.tht5_rad_new;

            return steps;
        }

        public int[] GoInverse()
        {
            int[] steps = new int[5];

            //TODO: Check does it need a second recalculation.
            InverseKinematics(this.AbsoluteRoll);

            steps[0] = (int)Math.Round((this.tht1_rad_new - this.theta1Rad) * S1, 0);
            steps[1] = (int)Math.Round((this.tht2_rad_new - this.theta2Rad) * S2, 0);
            steps[2] = (int)Math.Round((this.tht3_rad_new - this.theta3Rad) * S3, 0);
            steps[3] = (int)Math.Round((this.tht4_rad_new - this.theta4Rad) * S4, 0);
            steps[4] = (int)Math.Round((this.tht5_rad_new - this.theta5Rad) * S5, 0);

            this.theta1Rad = this.tht1_rad_new;
            this.theta2Rad = this.tht2_rad_new;
            this.theta3Rad = this.tht3_rad_new;
            this.theta4Rad = this.tht4_rad_new;
            this.theta5Rad = this.tht5_rad_new;

            return steps;
        }

        #endregion

        #region Private Methods

        public static double DegToRad(double deg)
        {
            return Math.PI * deg / 180.0d;
        }

        public static double RadToDeg(double rad)
        {
            return 180 * rad / Math.PI;
        }

        /// <summary>
        /// Forward kinematics model.
        /// </summary>
        private void ForwardKinematics()
        {
            lock (this.syncCalculations)
            {
                this.tht1_rad_new = Kinematics.DegToRad(this.theta1);
                this.tht2_rad_new = Kinematics.DegToRad(this.theta2);
                this.tht3_rad_new = Kinematics.DegToRad(this.theta3);
                this.tht4_rad_new = Kinematics.DegToRad(this.theta4);
                this.tht5_rad_new = Kinematics.DegToRad(this.theta5);

                this.pRad = 0.5 * (this.theta5Rad + this.theta4Rad);
                this.rRad = 0.5 * (this.theta5Rad - this.theta4Rad);
                this.RR_mm = L_mm * Math.Cos(this.theta2Rad) + L_mm * Math.Cos(this.theta3Rad) + LL_mm * Math.Cos(this.pRad);
                this.xmm = (this.RR_mm * Math.Cos(this.theta1Rad));
                this.ymm = (this.RR_mm * Math.Sin(this.theta1Rad));
                this.zmm = (H_mm + L_mm * Math.Sin(this.theta2Rad) + L_mm * Math.Sin(theta3Rad) + LL_mm * Math.Sin(this.pRad));
                this.pdeg = Kinematics.RadToDeg(pRad);
                this.rdeg = Kinematics.RadToDeg(rRad);
            }
        }
        
        /// <summary>
        /// Inverse kinematics model.
        /// </summary>
        /// <param name="absoluteRoll">Weight of absolute roll.</param>
        private void InverseKinematics(bool absoluteRoll)
        {
            lock (this.syncCalculations)
            {
                double Rw, Zw, h, b, alpha, beta;

                this.pRad = Kinematics.DegToRad(this.pdeg);
                this.rRad = Kinematics.DegToRad(this.rdeg);

                this.RR_mm = Math.Sqrt(this.xmm * this.xmm + this.ymm * this.ymm);

                this.tht1_rad_new = Math.Atan2(this.ymm, this.xmm);

                this.tht4_rad_new = this.pRad + this.rRad + (absoluteRoll ? 0 : 1) * this.theta1Rad;
                this.tht5_rad_new = this.pRad - this.rRad - (absoluteRoll ? 0 : 1) * this.theta1Rad;

                Rw = this.RR_mm - LL_mm * Math.Cos(this.pRad);
                Zw = this.zmm - LL_mm * Math.Sin(this.pRad) - H_mm;

                beta = Math.Atan2(Zw, Rw);

                b = 0.5 * Math.Atan(Math.Sqrt(Zw * Zw + Rw * Rw));

                if (b < L_mm)
                {
                    h = Math.Sqrt(L_mm * L_mm - b * b);
                }
                else
                {
                    h = 0;
                }

                alpha = Math.Atan2(h, b);

                this.tht2_rad_new = alpha + beta;
                this.tht3_rad_new = beta - alpha;

                this.theta1 = Math.Round(Kinematics.RadToDeg(this.tht1_rad_new), 0);
                this.theta2 = Math.Round(Kinematics.RadToDeg(this.tht2_rad_new), 0);
                this.theta3 = Math.Round(Kinematics.RadToDeg(this.tht3_rad_new), 0);
                this.theta4 = Math.Round(Kinematics.RadToDeg(this.tht4_rad_new), 0);
                this.theta5 = Math.Round(Kinematics.RadToDeg(this.tht5_rad_new), 0);
            }
        }

        #endregion

    }
}
