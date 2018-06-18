using ShopCartLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShoppingCart
{
    public partial class ShoppingCartForm : Form
    {
        private Store store = new Store();
        private List<Movie> CartListBoxData = new List<Movie>();
        BindingSource CartBindingReset = new BindingSource();
        private decimal Profit = 0;
        private decimal TotalMoneySpend = 0;

        public ShoppingCartForm()
        {
            InitializeComponent();
            StaffedSetupData();
            // Total Price


            // Store Movies
            MoviesInStorelistbox.DataSource = store.ListofMovies;
            MoviesInStorelistbox.DisplayMember = "Display";
            MoviesInStorelistbox.ValueMember = "Display";



            // Cart Movies


            CartBindingReset.DataSource = CartListBoxData;
            MoviesInCartlistbox.DataSource = CartBindingReset;

            MoviesInCartlistbox.DisplayMember = "Display";
            MoviesInCartlistbox.ValueMember = "Display";
        }
        private void StaffedSetupData()
        {
            store.Name = "Best Movies";

            store.ListofMovies.Add(new Movie { Title = "Iron Man", Discription = "A rich Man creates a robot suit", SellingPrice = 22.03M, BuyingPrice = 9.80M });
            store.ListofMovies.Add(new Movie { Title = "Titanic", Discription = "The largest ship Titanic", SellingPrice = 16.06M, BuyingPrice = 7.20M });
            store.ListofMovies.Add(new Movie { Title = "Beauty and the Beast", Discription = "Life is hard", SellingPrice = 15.50M, BuyingPrice = 5.50M });
            store.ListofMovies.Add(new Movie { Title = "Iron Man2", Discription = "A rich Man creates a robot suit 2", SellingPrice = 13.03M, BuyingPrice = 5.80M });
            store.ListofMovies.Add(new Movie { Title = "James Bond", Discription = "The best secret agent", SellingPrice = 20.06M, BuyingPrice = 2.20M });
            store.ListofMovies.Add(new Movie { Title = "Deep Sea", Discription = "The sea is only 5% explored", SellingPrice = 11.50M, BuyingPrice = 4.50M });
            store.ListofMovies.Add(new Movie { Title = "Fear the Dinosaurs", Discription = "Dinosaurs", SellingPrice = 15.06M, BuyingPrice = 9.20M });
            store.ListofMovies.Add(new Movie { Title = "V for Vendetta", Discription = "Masked Man", SellingPrice = 18.50M, BuyingPrice = 4.50M });
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Movie SelectedItem = (Movie)MoviesInStorelistbox.SelectedItem;

            CartListBoxData.Add(SelectedItem);
            CartBindingReset.ResetBindings(false);


        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {
            Movie SelectedItem = (Movie)MoviesInCartlistbox.SelectedItem;

            CartListBoxData.Remove(SelectedItem);
            CartBindingReset.ResetBindings(false);
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            foreach (Movie movie in CartListBoxData)
            {
                Profit += (decimal)movie.SellingPrice - movie.BuyingPrice;
                TotalMoneySpend += (decimal)movie.SellingPrice;
                

            }

            ProfitNumberlabel.Text = string.Format("${0}", Profit);
            MoneySpendNumberlabel.Text = string.Format("${0}", TotalMoneySpend);




            MessageBox.Show("Thank you");
            CartListBoxData.Clear();
            CartBindingReset.ResetBindings(false);
        }
    } 
}