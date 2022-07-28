﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;

// Name: Kristiin Tribbeck
// Date: 19/07/2022
// This application will utilise two advanced sorting algorithms and two binary
// searching techniques so it can compare the processing of raw data as it is collected. 

namespace MalinSpaceProject
{
    public partial class MalinSpaceSensors : Form
    {
        public MalinSpaceSensors()
        {
            InitializeComponent();
        }
        // 4.1	Create two data structures using the LinkedList<T> class
        // from the C# Systems.Collections.Generic namespace.
        // The data must be of type “double”.
        #region Properties
        static LinkedList<double> SensorA = new LinkedList<double>();
        static LinkedList<double> SensorB = new LinkedList<double>();
        #endregion
        // 4.2	Copy the Galileo.DLL file into the root directory of your solution folder
        // and add the appropriate reference in the solution explorer. 
        #region Load and populate sensors
        private void PopulateSensors()
        {
            Galileo.ReadData num = new Galileo.ReadData();
            int collectionSize = 400;
            SensorA.Clear();
            SensorB.Clear();
            for (int i = 0; i < collectionSize; i++)
            {
                SensorA.AddLast(num.SensorA((double)sigmaNumericUpDown.Value, (double)muNumericUpDown.Value));
                SensorB.AddLast(num.SensorB((double)muNumericUpDown.Value, (double)sigmaNumericUpDown.Value));
            }
        }
        // 4.3	Create a custom method called “ShowAllSensorData” which will display
        // both LinkedLists in a ListView. Add column titles “Sensor A” and “Sensor B”
        // to the ListView. The input parameters are empty, and the return type is void.
        private void ShowAllSensorData()
        {
            PopulateSensors();
            listviewDisplaybox.Items.Clear();
            for (int i = 0; i < SensorA.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(SensorA.ElementAt(i).ToString());
                lvi.SubItems.Add(SensorB.ElementAt(i).ToString());
                listviewDisplaybox.Items.Add(lvi);    
            }
        }
        // 4.4	Create a button and associated click method
        // that will call the LoadData and ShowAllSensorData methods.
        // The input parameters are empty, and the return type is void.
        private void loadSensorDataButton_Click(object sender, EventArgs e)
        {
            ShowAllSensorData();
            DisplayListboxData(SensorA, listBoxDisplaySensorA);
            DisplayListboxData(SensorB, listBoxDisplaySensorB);
        }
        // 4.5 Create a method called “NumberOfNodes” that will return an integer
        // which is the number of nodes(elements) in a LinkedList.
        // The method signature will have an input parameter of type LinkedList,
        // and the calling code argument is the linkedlist name.

        // 4.6 Create a method called “DisplayListboxData” that will display
        // the content of a LinkedList inside the appropriate ListBox. 
        // The method signature will have two input parameters; a LinkedList,
        // and the ListBox name. The calling code argument is the linkedlist name
        // and the listbox name.
        #endregion
        #region Utility methods
        private int NumberOfNodes(LinkedList<double> sensorName)
        {
            return sensorName.Count();
        }
        private void DisplayListboxData(LinkedList<double> sensorType, ListBox listBoxName)
        {
            for (int i = 0; i < SensorA.Count; i++)
            {
                listBoxDisplaySensorA.Items.Add(SensorA.ElementAt(i).ToString());
                listBoxDisplaySensorB.Items.Add(SensorB.ElementAt(i).ToString());
            }
        }
        #endregion
        // 4.14	Add two textboxes for the search value;
        // one for each sensor, ensure only numeric values can be entered.
        #region TextBoxes
        #endregion

        #region Binary search methods

        #endregion
    }
}