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
        

        #region funciones
        private async Task<string> texto()
        {
            

            Texto = "Espera"; 
            Run= true;
            await Task.Delay(2000);
         
            if (Dalay.IsRunning) { 
                Texto = "ye";
                Run = false;
            }
            await Task.Delay(2000);

            return Texto ="Inactivo";

        }
        
        private void cambinombre() {
            Clicksn++;
            if (Clicksn == 3)
            {
                Nombre = "Sacatapa";
            }
            else
            {
                Nombre = "Paco";
            }
        }
        private async Task<int> incre()
        {
            await Task.Delay (5000);
            Contador = Contador + 5;
            Clicks++;
           if (Clicks == 1) { 
                Coso = "Le diste "+ Clicks + "  vez";
           }
            else
            {
                Coso = "Le diste " + Clicks + "  veces";
            }

            return Contador;
          
        }
        private void insertarimagen() => Url = "https://assets.msn.com/weathermapdata/1/static/weather/Icons/taskbar_v10/Condition_Card/SunnyDayV3.svg";
        #endregion 


        #region propiedades
       
        private string _texto;
        public string Texto
        {
            get=> _texto; set => SetProperty(ref _texto, value);
        }
        private bool _run;
        public bool Run
        {
            get => _run; set => SetProperty(ref _run, value);
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
        private int _clicks;
        public int Clicks
        {
            get => _clicks;
            set => SetProperty(ref _clicks, value);
        }
        private int _clicksn;
        public int Clicksn
        {
            get => _clicksn;
            set => SetProperty(ref _clicksn, value);
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
