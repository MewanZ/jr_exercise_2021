using System.Collections.Generic;

namespace CouncilWise
{
    internal class Receipt
    {
        public Receipt()
        {
            Items = new List<ReceiptItem>();
        }
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }

        public override string ToString()
        {
            string printReceipt = "Receipt:\n" + "\tItems:\n";
            foreach (ReceiptItem item in Items)
            {
                if (item.IncludesTax)
                {
                    printReceipt += "\t" + item.Name + "\n" + "\t\t" + item.Quantity.ToString() + "\t" + item.UnitPrice.ToString() + "\t" + (item.UnitPrice * item.Quantity) + "\n";
                }
                else
                {
                    printReceipt += "\t" + item.Name + "\n" + "\t\t" + item.Quantity.ToString() + "\t" + item.UnitPrice.ToString() + "\t" + ((item.UnitPrice + item.TaxAmount) * item.Quantity) + "\n";
                }

            }
            printReceipt += "Total: " + Total + "\n" + "GST: " + TaxTotal + "\n";
            return printReceipt;

        }
    }
}
