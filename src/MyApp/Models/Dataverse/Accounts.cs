namespace MyApp.Models.Dataverse
{
    internal class Accounts
    {
        public class WithRevenue
        {
            public class Rootobject
            {
                public string odatacontext { get; set; }
                public Value[] value { get; set; }
            }

            public class Value
            {
                public string odataetag { get; set; }
                public string name { get; set; }
                public float revenue { get; set; }
                public string _transactioncurrencyid_value { get; set; }
                public string accountid { get; set; }
            }
        }
    }
}
