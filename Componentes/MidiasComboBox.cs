using LocadoraApp2.Classes;
using LocadoraApp2.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraApp2.Componentes
{
    public partial class MidiasComboBox : ComboBox  
    {
        public MidiasComboBox()
        {
           this.DropDownStyle = ComboBoxStyle.DropDownList;

           
        }
        public void CarregarMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                this.DataSource = contexto.
                    Midias
                    .OrderBy(m => m.Titulo)
                    .ToList();

                this.DisplayMember = "Titulo";

                this.ValueMember = "MidiaId";
            }
            
        }

        public Midia? MidiaSelecionada
        {
            get
            {
                return this.SelectedItem as Midia;
            }
        }
        public int? midiaIdSelecionada
        {
            get
            {
                return this.SelectedItem as int?;   
            }
        }

 
    }
}
