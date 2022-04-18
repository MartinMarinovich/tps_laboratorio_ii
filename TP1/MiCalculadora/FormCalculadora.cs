using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        public FormCalculadora()
        {
            InitializeComponent();
                 
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            CargarCombo();
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvetirADecimal.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvetirADecimal.Enabled = false;
        }

        private void btn_Operar_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (ValidarCampos(txtbOperando1.Text, txtbOperando2.Text))
            {
                if (cmbOperador.Text != " ")
                {
                    result = Operar(txtbOperando1.Text, txtbOperando2.Text, cmbOperador.Text);


                    if (result == double.MinValue)
                    {
                        lblResultado.Text = "Error, no se puede dividir por 0";
                    }
                    else
                    {
                        lblResultado.Text = result.ToString();
                        lst_Operaciones.Items.Add(string.Format($"{txtbOperando1.Text}  {cmbOperador.Text}  {txtbOperando1.Text} = {result.ToString()}"));
                        btnConvertirABinario.Enabled = true;
                    }
                }
                else
                {
                    lblResultado.Text = "Ingrese un operador";
                }
            }
            else
            {
                lblResultado.Text = "Ingrese operandos validos";
            }
        }

        /// <summary>
        /// Metodo privado para limpiar los campos, los pone en vacio
        /// </summary>

        private void Limpiar()
        {
            txtbOperando1.Text = "";
            txtbOperando2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
            

        }
        /// <summary>
        /// Metodo privado que inicializa el combo con los operadores
        /// </summary>
        private void CargarCombo()
        {
            List<char> operadores = new List<char>()
            {
               ' ','+','-','/','*'
            };

            foreach (char item in operadores)
            {
                cmbOperador.Items.Add(item);

            }
        }

        /// <summary>
        /// Valida que los valores ingresados en los campos sean correctos.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        private bool ValidarCampos(string numero1, string numero2)
        {
            double aux = 0;

            if (!string.IsNullOrWhiteSpace(numero1) && !string.IsNullOrWhiteSpace(numero2) 
                && double.TryParse(numero2 , out aux) && double.TryParse(numero1, out aux))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metodo estatico operarar, devuelve un doble, recibe 2 strings de numeros y un operador, realiza la operacion correspondiente
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>resultado</returns>

        public static double Operar(string numero1, string numero2 , string operador )
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char operadorChar = char.Parse(operador);
    
            return Calculadora.Operar(operando1, operando2, operadorChar);
        }

        private void btn_ConvetirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                Operando numero = new Operando();

                lblResultado.Text = numero.BinarioADecimal(lblResultado.Text);
                btnConvetirADecimal.Enabled = false;
                btnConvertirABinario.Enabled = true;

            }
        }

        private void btn_ConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                Operando numero = new Operando();

                lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
                btnConvertirABinario.Enabled = false;
                btnConvetirADecimal.Enabled = true;
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
