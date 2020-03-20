using System;

namespace APPBASE.Services
{
    public class Calculator : ICalculator
    {
        protected int? YEAR { get; set; }
        protected int? DAYS { get; set; }
        protected int? QTY { get; set; }

        protected decimal? NET_AMOUNT { get; set; }
        protected decimal? GROSS_AMOUNT { get; set; }
        protected decimal? DISC_RATE { get; set; }
        protected decimal? PRICE { get; set; }


        protected void calc() {
            decimal? nDisc = 0;

            nDisc = nDisc + this.discDays();
            nDisc = nDisc + this.discQty();
            nDisc = nDisc + this.discYear();

            this.DISC_RATE = nDisc;
            this.GROSS_AMOUNT = calcGross();
            this.NET_AMOUNT = this.GROSS_AMOUNT - (this.GROSS_AMOUNT * (this.DISC_RATE / 100));

        }

        protected decimal? calcNet()
        {
            decimal? nValue = 0;
            nValue = (this.PRICE * this.QTY) * this.DAYS;

            return nValue;
        }

        protected decimal? calcGross()
        {
            decimal? nValue = 0;
            nValue = (this.PRICE * this.QTY) * this.DAYS;

            return nValue;
        }

        protected decimal? discDays() {
            if (this.DAYS >= 3)
            {
                return 5;
            }

            return 0;
        }

        protected decimal? discQty()
        {
            if (this.QTY >= 2)
            {
                return 10;
            }

            return 0;
        }

        protected decimal? discYear()
        {
            if (this.YEAR < 2010)
            {
                return 7;
            }

            return 0;
        }

        public Calculator(int? parYear, int? parDays, int? parQty, decimal? parPrice)
        {
            this.YEAR = parYear;
            this.DAYS = parDays;
            this.QTY = parQty;
            this.PRICE = parPrice;

            this.calc();
        }

        public decimal? getDiscRate()
        {
            return this.DISC_RATE;
        }

        public decimal? getGrossAmount()
        {
            return this.GROSS_AMOUNT;
        }

        public decimal? getNetAmount()
        {
            return this.NET_AMOUNT;
        }
    }
}