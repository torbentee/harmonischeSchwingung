using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace harmonischeSchwingung
{
    public class schwingung
    {
        private double _Amplitute;
        private double _Frequenz;
        private double _Phasenverschiebung;

        private double _KreisFrequenz;
        private double _Periodendauer;

        public schwingung(double Amplitude, double Frequenz, double Phasenverschiebung)
        {
            _Amplitute = Amplitude;
            _Frequenz = Frequenz;
            _Phasenverschiebung = Phasenverschiebung;

            _KreisFrequenz = 2 * Math.PI * _Frequenz;
            _Periodendauer = 1 / _Frequenz;
        }

        #region Accessoren
        public double Amplitude
        { 
            set
            {
                _Amplitute = value;
            }
        }

        public double Frequenz
        {
            set
            {
                _Frequenz = value;
            }
        }

        public double Phasenverschiebung
        {  
            set
            {
                _Phasenverschiebung = value;
            }
        }

        public double Periodendauer
        {
            get
            {
                return (_Periodendauer);
            }
    }
        #endregion

        public double zeitOrtCalc(double x)
        {   
            double solution = _Amplitute * Math.Sin(_KreisFrequenz * x  + _Phasenverschiebung);
            
            return (solution);
        }

        

        public double zeitGeschwindigkeitCalc(double x)
        {
            double solution = _Amplitute * _KreisFrequenz * Math.Cos(_KreisFrequenz * x + _Phasenverschiebung);

            return (solution);

        }

        public double zeitBeschleunigungCalc(double x)
        {
            double solution = -_Amplitute * Math.Pow(_KreisFrequenz, 2) * Math.Sin(_KreisFrequenz * x + _Phasenverschiebung);

            return (solution);
        }

        public string debug()
        {
            string a = Convert.ToString(_Frequenz + _Phasenverschiebung);
            return (a);
        }
    }
}
