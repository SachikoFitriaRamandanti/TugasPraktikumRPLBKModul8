using System;
namespace TempConv
{
    public class TempConvComp
    {
        public TempConvComp()
        {
        }
        public double cToF(double c)
        {
            return (int)((c * 9 / 5.0 + 32) * 100) / 100.0;
        }
        public double cToK(double c)
        {
            return (int)((c + 273) * 100) / 100.0;
        }
        public double cToR(double c)
        {
            return (int)((c * 4 / 5 * 100)/100.0);
        }

        public double fToC(double f)
        {
            return (int)((f - 32) * 5 / 9.0 * 100) / 100.0;
        }
        public double fToR(double f)
        {
            return (int)((f - 32) * 4 / 9.0 * 100) / 100.0;
        }
        public double fToK(double f)
        {
            return (int)((f - 32) * 5 / 9.0) + 273.15;
        }

        public double kToR(double k)
        {
            return (int)((k - 273) * 4 / 5 * 100) / 100.0;
        }
        public double kToF(double k)
        {
            return (int)((k - 273) * 9 / 5.0 * 100) / 100 + 32;
        }
        public double kToC(double k)
        {
            return (int)((k - 273) * 100) / 100.0;
        }

        public double rToC(double r)
        {
            return (int)((r * 5) / 4 * 100) / 100.0;
        }
        public double rToF(double r)
        {
            return (int)(r * 9 / 4 * 100) / 100.0 + 32;
        }
        public double rToK(double r)
        {
            return (int)((r * 5) / 4 * 100) / 100.0 + 273;
        }
    }
}