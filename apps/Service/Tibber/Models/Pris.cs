using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Tibber.Sdk;
using YamlDotNet.Core.Tokens;

namespace NetDaemonApps.apps.Service.Tibber.Models
{
    public class Pris : Price
    {
        private static readonly decimal Overforingsavgift = 0.2225m; //överföringsavgift nätavgift
        private static readonly decimal Energiskatt = 0.45m; //energiskatt på nätavgift

        public Pris(Price price)
        {
            Currency = price.Currency;
            Energy = price.Energy;
            Level = price.Level;
            StartsAt = price.StartsAt;
            Tax = price.Tax;
            Total = price.Total;
        }

        public DateTime StartTid => DateTime.Parse(StartsAt);
        public decimal? TotalPriceInkElnat => Total + Overforingsavgift + Energiskatt;
    }
}
