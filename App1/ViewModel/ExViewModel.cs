using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace App1.ViewModel
{
    public class ExViewModel : ObservableRecipient
    {
        public ExViewModel() {
            CambiarNombre = new RelayCommand(cambinombre);
            Insert = new RelayCommand (insertarimagen);
            Dalay = new AsyncRelayCommand(texto);
            IncrementaCommand = new AsyncRelayCommand(incre);

        }
        


        private async Task<string> texto()
        {


            Texto = "Espera"; 
            await Task.Delay(1000);

            if (Dalay.IsRunning) Texto ="ye";
            return Texto;

        }

        private void cambinombre() => Nombre = "Paco";
        private async Task<int> incre()
        {
            await Task.Delay (5000);
          if (Contador == 15)
            {
                Coso = "Le diste 3 veces";
            }
            
            return Contador = Contador + 5;
          
        }
        private void insertarimagen() => Url = "https://images9.engageya.com/02/e1/website_249324/b7/38/8a/images9.engageya.com.engageyaf22794a7-436c-4100-a31a-6e2f5ea11e6a_new_post_image_951064_25.jpg";

        #region propiedades
        public bool Semueve = false;
        private string _texto;
        public string Texto
        {
            get=> _texto; set => SetProperty(ref _texto, value);
        } 
        private string _coso;
        public string Coso
        {
            get=> _coso; set => SetProperty(ref _coso, value);
        }

        
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set  => SetProperty(ref _nombre, value);
        }
        private string _textovivo;
        public string TextoVivo
        {
            get => _textovivo;
            set  => SetProperty(ref _textovivo, value);
        }
        private string _url;
        public string Url
        {
            get => _url;
            set => SetProperty(ref _url, value);
        }
        private int _contador;
        public int Contador
        {
            get => _contador;
            set => SetProperty(ref _contador, value);
        }
        #region command
        public ICommand CambiarNombre { get; set; }
        public ICommand Insert { get; set; }
        public ICommand IncrementaCommand { get; set; }
        public IAsyncRelayCommand Dalay { get; set; }
        #endregion
        #endregion
    }
}
