using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
  public class Facade
    {
        private Distribuition Distribuition;
        private Financial Financial;
        private Fiscal Fiscal;
        private Quality Quality;
        private Sale Sale;


        public Facade()
        {
            Distribuition = new Distribuition();
            Fiscal = new Fiscal();
            Financial = new Financial();
            Quality = new Quality();
            Sale = new Sale();
        }


        public void Buy()
        {
            this.Sale.BuildSale();
            this.Fiscal.CalculateFiscalTax();
            this.Financial.FinancialReg();
            this.Distribuition.SeparateProduct();
            SendProduct();
        }

        private void SendProduct()
        {
            this.Quality.CheckQuality();
            this.Financial.PrintInvoice();
            this.Quality.ValidateQuality();
            this.Distribuition.SendProduct();
        }
    }


    


}
