﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public string textoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", FREIO_ABS);
            }
        }
        public string textoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", AR_CONDICIONADO);
            }
        }

        public string textoMP3Player
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", MP3_PLAYER);
            }
        }
        public Veiculo Veiculo { get; set; }

        public bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }

            set
            {
                temFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }

            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool temMP3Player;
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }

            set
            {
                temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }


        public string ValorTotal
        {
            get
            {
                return string.Format(
                 "Valor Total: R$ {0}",Veiculo.Preco
                 + (TemFreioABS ? FREIO_ABS : 0)
                 + (TemArCondicionado ? AR_CONDICIONADO : 0)
                 +(TemMP3Player ? MP3_PLAYER : 0)
                 );
            }
        }
        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void ButtonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo));
        }
    }
}