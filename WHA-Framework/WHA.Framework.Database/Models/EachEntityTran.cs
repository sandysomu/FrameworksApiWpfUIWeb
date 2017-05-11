namespace  WHA.Framework.Database.Models

{
    public class EachEntityTran
    {
        public int IndividualID { get; set; }
        public double? Amount { get; set; }
        public long ? CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public string TransactionType { get; set; }
    }


}