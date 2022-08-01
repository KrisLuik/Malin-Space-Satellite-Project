using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;
using System.Diagnostics;

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
                SensorA.AddLast(num.SensorA((double)muNumericUpDown.Value, (double)sigmaNumericUpDown.Value));
                SensorB.AddLast(num.SensorB((double)muNumericUpDown.Value, (double)sigmaNumericUpDown.Value));
            }
            ShowAllSensorData();
            DisplayListboxData(SensorA, listBoxDisplaySensorA);
            DisplayListboxData(SensorB, listBoxDisplaySensorB);
        }
        // 4.3	Create a custom method called “ShowAllSensorData” which will display
        // both LinkedLists in a ListView. Add column titles “Sensor A” and “Sensor B”
        // to the ListView. The input parameters are empty, and the return type is void.
        private void ShowAllSensorData()
        {
            // list view display
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
            PopulateSensors();
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
            listBoxName.Items.Clear();
            foreach (var node in sensorType)
            {
                listBoxName.Items.Add(node);
            }
        }
        #endregion
        // 4.14	Add two textboxes for the search value;
        // one for each sensor, ensure only numeric values can be entered.
        #region TextBoxes Input Handling
        private void KeyPressAction(Object sender, KeyPressEventArgs e)
        {
            // "sender" stands for the object that raises the event.
            // I am casting the sender using "as" keyword to avoid runtime exception
            // that would occur if I used "Textbox tb = Textbox(sender)".
            TextBox tb = sender as TextBox;

            if (tb == null)
            {
                MessageBox.Show("Keypress event was not fired by a textbox.");
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Only allow one decimal point.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList,
        // while the calling code argument is the linkedlist name. The method code must follow the pseudo
        // code supplied below in the Appendix. The return type is Boolean.
        #region Binary search methods
        private bool SelectionSort(LinkedList<double> unsortedList)
        {
            int min = 0;
            int max = NumberOfNodes(unsortedList);
            for (int i = 0; i < max - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (unsortedList.ElementAt(j).CompareTo(unsortedList.ElementAt(min)) < 0)
                    {
                        min = j;
                    }
                }
                LinkedListNode<double> currentMin = unsortedList.Find(unsortedList.ElementAt(min));
                LinkedListNode<double> currentI = unsortedList.Find(unsortedList.ElementAt(i));
                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
            }
            return true;

        }
        #endregion
        #region Selection Sort Buttons
        // SensorA Selection Sort Button
        private void selectionSortSensorABtn_MouseClick(object sender, MouseEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SelectionSort(SensorA);
            sw.Stop();  
            ShowAllSensorData();
            DisplayListboxData(SensorA, listBoxDisplaySensorA);
            textboxSelectionSortSensorA.Text = String.Format("{0} ms", sw.ElapsedMilliseconds);

        }
        // SensorB Selection Sort Button
        private void selectionSortSensorBBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SelectionSort(SensorB);
            sw.Stop();
            ShowAllSensorData();
            DisplayListboxData(SensorB, listBoxDisplaySensorB);
            textboxSelectionSortSensorB.Text = String.Format("{0} ms", sw.ElapsedMilliseconds);
        }
        #endregion
        // 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList,
        // while the calling code argument is the linkedlist name. The method code must follow the pseudo
        // code supplied below in the Appendix. The return type is Boolean.
        #region Insertion Sort Method
        private bool InsertionSort(LinkedList<double> unsortedList)
        {
            int max = NumberOfNodes(unsortedList);
            for (int i = 0; i < max - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (unsortedList.ElementAt(j - 1).CompareTo(unsortedList.ElementAt(j)) > 0)
                    {
                        LinkedListNode<double> current = unsortedList.Find(unsortedList.ElementAt(j));
                        var temp = current.Previous.Value;
                        current.Previous.Value = current.Value;
                        current.Value = temp;
                    }
                }
            }
            return true;
        }
        // SensorA 
        private void insertionSortSensorABtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            InsertionSort(SensorA);
            sw.Stop();
            ShowAllSensorData();
            DisplayListboxData(SensorA, listBoxDisplaySensorA);
            textboxInsertionSensorA.Text = String.Format("{0} ms", sw.ElapsedMilliseconds);
        }
        // SensorB
        private void insertionSortSensorBBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            InsertionSort(SensorB);
            sw.Stop();
            ShowAllSensorData();
            DisplayListboxData(SensorB, listBoxDisplaySensorB);
            textboxInsertionSensorB.Text = String.Format("{0} ms", sw.ElapsedMilliseconds);
        }
        #endregion
        // 4.9	Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum.
        // This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value. The calling code argument is the linkedlist.
        // name, search value, minimum list size and the number of nodes in the list. The method code must follow the pseudo code supplied below in the Appendix.
        private int BinarySearchIterative(LinkedList<double> list, TextBox searchValue, int min, int max)
        {
            min = ((int)list.First.Value);
            max = NumberOfNodes(list);
            int target = int.Parse(searchValue.Text); 
            
            while(min < max - 1)
            {
                int mid = ((min + max) / 2);
                if (target.Equals(list.ElementAt(mid) == 0))
                {
                    return ++mid;
                }
                else if (target.Equals(list.ElementAt(mid) < 0))
                {
                    max = mid - 1;
                 
                }
                else
                {
                    min = mid + 1;
                }
            }
            return min;
        }

        private void iterativeSearchSensorABtn_Click(object sender, EventArgs e)
        {
           // BinarySearchIterative(SensorA, textBoxSearchTargetA.Text ,(int)SensorA.First.Value,(int)SensorA.Last.Value);
        }
    }
}
