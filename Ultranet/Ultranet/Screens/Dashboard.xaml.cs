using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultranet.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Ultranet.Screens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : Grid
    {
        public Dashboard()
        {
            InitializeComponent();
            accounts.ItemsSource = new account[] { new account { name = "Main Wallet", address = "0x07ea51bb99e29eb9", coins = "5005" }, new account { name = "Main Wallet", address = "0x07ea51bb99e29eb9", coins = "5005" }, new account { name = "Main Wallet", address = "0x07ea51bb99e29eb9", coins = "5005" } };
            transactions.ItemsSource = new transaction[] { new transaction { transactiontext = ", 590 UNT, 0x990 -> 0x998...", status= "processing.svg", statusdark= "processingdark.svg" }, new transaction { transactiontext = ", 590 UNT, 0x990 -> 0x998...", status= "success.svg", statusdark = "successdark.svg" }, new transaction { transactiontext = ", 590 UNT, 0x990 -> 0x998...", status= "declined.svg", statusdark = "declineddark.svg" }, };
        }
    }
}