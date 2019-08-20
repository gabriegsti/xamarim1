using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestDrive.Views
{
  public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
                get { return string.Format("R$ {0}", Preco); }
        }
    }
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo{Nome="Azera V6",Preco=60000},
                new Veiculo{Nome="Fiesta 2.0",Preco=50000},
                new Veiculo{Nome="HB20 S",Preco=40000}
            };

            this.BindingContext = this;

        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo) e.Item;
            Navigation.PushAsync(new DetalheView(veiculo));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanging(propertyName);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        protected override void OnTabIndexPropertyChanged(int oldValue, int newValue)
        {
            base.OnTabIndexPropertyChanged(oldValue, newValue);
        }

        protected override int TabIndexDefaultValueCreator()
        {
            return base.TabIndexDefaultValueCreator();
        }

        protected override void OnTabStopPropertyChanged(bool oldValue, bool newValue)
        {
            base.OnTabStopPropertyChanged(oldValue, newValue);
        }

        protected override bool TabStopDefaultValueCreator()
        {
            return base.TabStopDefaultValueCreator();
        }

       

        protected override void InvalidateMeasure()
        {
            base.InvalidateMeasure();
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return base.OnMeasure(widthConstraint, heightConstraint);
        }

       

        protected override void ChangeVisualState()
        {
            base.ChangeVisualState();
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            base.LayoutChildren(x, y, width, height);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        protected override void OnChildMeasureInvalidated(object sender, EventArgs e)
        {
            base.OnChildMeasureInvalidated(sender, e);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }
    }
}
