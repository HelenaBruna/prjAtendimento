using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAtendimento.classes
{
    public class Senha
    {
        #region Propriedades
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Construtor 
        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Today;
            this.horaGerac = DateTime.Now;
        }
        #endregion

        #region Metodos
        public string dadosParciais()
        {
            return $"{id} - {DataGerac.ToShortDateString()} - {HoraGerac.ToShortTimeString()}\n";
        }

        public string dadosCompletos()
        {
            return $"{id} - {DataGerac.ToShortDateString()} - {HoraGerac.ToShortTimeString()} - {DataAtend.ToShortDateString()} - {HoraAtend.ToShortTimeString()}\n";
        }
        #endregion
    }
}
