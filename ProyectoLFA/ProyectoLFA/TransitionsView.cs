﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLFA.Clases;

namespace ProyectoLFA
{
    /// <summary>
    /// Representa la vista de las transiciones en el análisis léxico.
    /// </summary>
    public partial class TransitionsView : Form
    {
        private ET expressionTree; // Árbol de expresión
        private FollowTable follows; // Tabla de follows
        private TransitionT transitions; // Tabla de transiciones

        // Constructor predeterminado
        public TransitionsView()
        {
            InitializeComponent();
        }

        // Constructor que inicializa la vista con el árbol de expresión, la tabla de follows y la tabla de transiciones
        public TransitionsView(ET expressionTree, FollowTable follows, TransitionT transitions)
        {
            InitializeComponent();
            this.expressionTree = expressionTree;
            this.follows = follows;
            this.transitions = transitions;

            RTXtext.Text = expressionTree.expression; // Establece el texto en el cuadro de texto RTXtext
        }

        // Método para cargar las funciones del árbol de expresión en la tabla TreeTable
        private void loadFunctions()
        {
            List<string[]> functions = expressionTree.getValuesOfNodes(); // Obtiene los valores de los nodos del árbol de expresión

            // Agrega las columnas a TreeTable
            TreeTable.Columns.Add("SIMBOLO", "SIMBOLO");
            TreeTable.Columns.Add("FIRST", "FIRST");
            TreeTable.Columns.Add("LAST", "LAST");
            TreeTable.Columns.Add("NULLABLE", "NULLABLE");

            // Agrega las filas a TreeTable
            int length = functions.Count;
            for (int i = 0; i < length; i++)
            {
                TreeTable.Rows.Add();
                TreeTable.Rows[i].Cells[0].Value = functions[i][0];
                TreeTable.Rows[i].Cells[1].Value = functions[i][1];
                TreeTable.Rows[i].Cells[2].Value = functions[i][2];
                TreeTable.Rows[i].Cells[3].Value = functions[i][3];
            }
        }

        // Método para cargar los follows en la tabla FollowTable
        private void loadFollows()
        {
            // Agrega las columnas a FollowTable
            FollowTable.Columns.Add("SIMBOLO", "SIMBOLO");
            FollowTable.Columns.Add("FOLLOW", "FOLLOW");

            // Agrega las filas a FollowTable
            for (int rowIndex = 1; rowIndex < follows.nodes.Count; rowIndex++)
            {
                var item = follows.nodes[rowIndex];
                FollowTable.Rows.Add();
                FollowTable.Rows[rowIndex - 1].Cells[0].Value = item.character;
                FollowTable.Rows[rowIndex - 1].Cells[1].Value = string.Join(",", item.follows);
            }

            DataGridViewColumn column1 = FollowTable.Columns[0];
            DataGridViewColumn column2 = FollowTable.Columns[1];
        }

        // Método para cargar las transiciones en la tabla TransitionsTable
        private void loadTransitions()
        {
            int indexCount = 1;
            // Diccionario para almacenar el índice de cada símbolo
            Dictionary<string, int> index = new Dictionary<string, int>();

            // Agrega la columna "ESTADO" a TransitionsTable
            TransitionsTable.Columns.Add("ESTADO", "ESTADO");

            // Agrega las columnas correspondientes a los símbolos en TransitionsTable
            foreach (var item in transitions.symbolsList)
            {
                index.Add(item, indexCount);
                TransitionsTable.Columns.Add(item, item);
                indexCount++;
            }

            // Agrega las filas (estados) a TransitionsTable
            for (int i = 0; i < transitions.states.Count; i++)
            {
                TransitionsTable.Rows.Add();
                var item = string.Join(",", transitions.states[i]);
                TransitionsTable.Rows[i].Cells[0].Value = item;
            }

            // Agrega las celdas (transiciones) a TransitionsTable
            for (int i = 0; i < transitions.states.Count; i++)
            {
                foreach (var item in transitions.transitions[i])
                {
                    TransitionsTable.Rows[i].Cells[item.symbol].Value = string.Join(",", item.nodes);
                    // Rellena las celdas que son nulas con "---"
                    if (string.IsNullOrEmpty(TransitionsTable.Rows[i].Cells[item.symbol].Value.ToString()))
                    {
                        TransitionsTable.Rows[i].Cells[item.symbol].Value = "---";
                    }
                }
            }
        }

        // Método que se ejecuta cuando se carga la vista
        private void TransitionsView_Load(object sender, EventArgs e)
        {
            loadFunctions(); // Carga las funciones
            loadFollows(); // Carga los follows
            loadTransitions(); // Carga las transiciones
        }
    }
}
