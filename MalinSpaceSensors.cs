using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

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
        #endregion
        // 4.5 Create a method called “NumberOfNodes” that will return an integer
        // which is the number of nodes(elements) in a LinkedList.
        // The method signature will have an input parameter of type LinkedList,
        // and the calling code argument is the linkedlist name.

        // 4.6 Create a method called “DisplayListboxData” that will display
        // the content of a LinkedList inside the appropriate ListBox. 
        // The method signature will have two input parameters; a LinkedList,
        // and the ListBox name. The calling code argument is the linkedlist name
        // and the listbox name.
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
        #region Highlight Values in listbox method
        private void HighlightData(int searchedIndex, LinkedList<double> list, ListBox listbox)
        {
            listbox.ClearSelected();
            for (int i = searchedIndex - 3; i <= searchedIndex + 3; i++)
            {
                if (i < 0)
                {

                }
                else if (i > NumberOfNodes(list) - 1)
                {

                }
                else
                {
                    listbox.SelectedIndices.Add(i);
                }
            }
        }
        #endregion
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList,
        // while the calling code argument is the linkedlist name. The method code must follow the pseudo
        // code supplied below in the Appendix. The return type is Boolean.
        #region Binary Selection Sort Method
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
        // The button method must start a stopwatch before calling the sort method. Once the sort is complete
        // the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox.
        // Finally, the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.
        #region Selection Sort Buttons
        // SensorA Selection Sort Button.
        private void selectionSortSensorABtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (listviewDisplaybox.Items.Count > 0)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                SelectionSort(SensorA);
                sw.Stop();
                DisplayListboxData(SensorA, listBoxDisplaySensorA);
                textboxSelectionSortSensorA.Text = String.Format("{0:0.00} ms", sw.ElapsedMilliseconds);
                ClearTextBox(textBoxSearchTargetA);
            }
            else
            {
                MessageBox.Show("Error! Load data first!");
            }
        }
        // SensorB Selection Sort Button.
        private void selectionSortSensorBBtn_Click(object sender, EventArgs e)
        {
            if (listviewDisplaybox.Items.Count > 0)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                SelectionSort(SensorB);
                sw.Stop();
                DisplayListboxData(SensorB, listBoxDisplaySensorB);
                textboxSelectionSortSensorB.Text = String.Format("{0:0.00} ms", sw.ElapsedMilliseconds);
                ClearTextBox(textBoxSearchTargetB);
            }
            else
            {
                MessageBox.Show("Error! Load data first!");
            }
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
        #endregion
        #region Insertion Sort Buttons
        // SensorA insertion sort button. 
        private void insertionSortSensorABtn_Click(object sender, EventArgs e)
        {
            if (listviewDisplaybox.Items.Count > 0)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                InsertionSort(SensorA);
                sw.Stop();
                DisplayListboxData(SensorA, listBoxDisplaySensorA);
                textboxInsertionSensorA.Text = String.Format("{0:0.00} ms", sw.ElapsedMilliseconds);
                ClearTextBox(textBoxSearchTargetA);
            }
            else
            {
                MessageBox.Show("Error! Load data first!");
            }
        }
        // SensorB insertion sort button.
        private void insertionSortSensorBBtn_Click(object sender, EventArgs e)
        {
            if (listviewDisplaybox.Items.Count > 0)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                InsertionSort(SensorB);
                sw.Stop();
                DisplayListboxData(SensorB, listBoxDisplaySensorB);
                textboxInsertionSensorB.Text = String.Format("{0:0.00} ms", sw.ElapsedMilliseconds);
                ClearTextBox(textBoxSearchTargetB);
            }
            else
            {
                MessageBox.Show("Error! Load data first!");
            }
        }
        #endregion
        // 4.9	Create a method called “BinarySearchIterative” which has the following four parameters:
        // LinkedList, SearchValue, Minimum and Maximum.This method will return an integer of the linkedlist element
        // from a successful search or the nearest neighbour value. The calling code argument is 
        // the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        #region Binary Search Iterative Method
        private int BinarySearchIterative(LinkedList<double> list, double searchValue, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (searchValue == list.ElementAt(mid))
                {
                    return ++mid;
                }
                else if (searchValue < list.ElementAt(mid))
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
        #endregion
        #region Binary Search Iterative Buttons
        private void iterativeSearchSensorABtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchTargetA.Text))
            {
                if (SelectionSort(SensorA))
                {
                    DisplayListboxData(SensorA, listBoxDisplaySensorA);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int searchedIndex = BinarySearchIterative(SensorA, Double.Parse(textBoxSearchTargetA.Text.ToString()), 0, NumberOfNodes(SensorA));
                    sw.Stop();
                    HighlightData(searchedIndex, SensorA, listBoxDisplaySensorA);
                    textboxIterativeSensorA.Text = String.Format("{0} ticks", sw.ElapsedTicks);
                    ClearTextBox(textBoxSearchTargetA);
                }
            }
            else
            {
                MessageBox.Show("Error! Textbox is empty, enter a value to search.");
            }
        }
        private void iterativeSearchSensorBBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchTargetB.Text))
            {
                if (SelectionSort(SensorB))
                {
                    DisplayListboxData(SensorB, listBoxDisplaySensorB);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int searchedIndex = BinarySearchIterative(SensorB, Double.Parse(textBoxSearchTargetB.Text.ToString()), 0, NumberOfNodes(SensorB));
                    sw.Stop();
                    HighlightData(searchedIndex, SensorB, listBoxDisplaySensorB);
                    textboxIterativeSearchB.Text = String.Format("{0} ticks", sw.ElapsedTicks);
                    ClearTextBox(textBoxSearchTargetB);
                }
            }
            else
            {
                MessageBox.Show("Error! Textbox is empty, enter a value to search.");
            }
        }
        #endregion
        // 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters:
        // LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the
        // linkedlist element from a successful search or the nearest neighbour value. The calling code argument
        // is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        #region Binary Search Recursive Method
        private int BinarySearchRecursive(LinkedList<double> list, double searchValue, int min, int max)
        {
            if (min <= max - 1)
            {
                int mid = min + max / 2;
                if (searchValue == list.ElementAt(mid))
                {
                    return mid;
                }
                else if (searchValue < list.ElementAt(mid))
                {
                    return BinarySearchRecursive(list, searchValue, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(list, searchValue, mid + 1, max);
                }
            }
            return min;
        }
        #endregion
        #region Binary Search Recursive Buttons
        private void recusiveSearchSensorABtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchTargetA.Text))
            {
                if (InsertionSort(SensorA))
                {
                    DisplayListboxData(SensorA, listBoxDisplaySensorA);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    // check why code crashes when it's a negative integer.
                    int searchedIndex = BinarySearchIterative(SensorA, Double.Parse(textBoxSearchTargetA.Text.ToString()), 0, NumberOfNodes(SensorA));
                    sw.Stop();
                    HighlightData(searchedIndex, SensorA, listBoxDisplaySensorA);
                    textboxRecursiveSensorA.Text = String.Format("{0} ticks", sw.ElapsedTicks);
                    ClearTextBox(textBoxSearchTargetA);
                }
            }
            else
            {
                MessageBox.Show("Error! Textbox is empty, enter a value to search.");
            }
        }
        private void recursiveSearchSensorBBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchTargetB.Text))
            {
                if (InsertionSort(SensorB))
                {
                    DisplayListboxData(SensorB, listBoxDisplaySensorB);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int searchedIndex = BinarySearchIterative(SensorB, Double.Parse(textBoxSearchTargetB.Text.ToString()), 0, NumberOfNodes(SensorB));
                    sw.Stop();
                    HighlightData(searchedIndex, SensorB, listBoxDisplaySensorB);
                    textboxRecursiveSensorB.Text = String.Format("{0} ticks", sw.ElapsedTicks);
                    ClearTextBox(textBoxSearchTargetB);
                }
            }
            else
            {
                MessageBox.Show("Error! Textbox is empty, enter a value to search.");
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

            if ((tb.Text.IndexOf('-') > -1) && tb.SelectionStart == 0 && !tb.SelectedText.Contains('-'))
            {
                e.Handled = true;
            }
            // Do not accept a character that is not included in the following.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Only allow one decimal point.
            if ((e.KeyChar == '.') && (tb.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // The negative sign can only be at the start.
            if ((e.KeyChar == '-'))
            {
                // If the cursor is not at the start of the text, the key press is not valid.
                if (tb.SelectionStart > 0)
                {
                    e.Handled = true;
                }
                // If there is already a negative sign and the negative sign is not selected, the key press is not valid
                // This allows the user to highlight some of the text and replace it with a negative sign.
                if (tb.Text.IndexOf('-') > -1 && !tb.SelectedText.Contains('-'))
                {
                    e.Handled = true;
                }
            }
        }
       
        private void ClearTextBox(TextBox textboxSearch)
        {
            textboxSearch.Clear();
            textboxSearch.Focus();
        }
        private void ClearAllTextBoxesButton_Click(object sender, EventArgs e)
        {
            textboxIterativeSensorA.Clear();
            textboxRecursiveSensorA.Clear();
            textboxSelectionSortSensorA.Clear();
            textboxInsertionSensorA.Clear();

            textboxIterativeSearchB.Clear();
            textboxRecursiveSensorB.Clear();
            textboxSelectionSortSensorB.Clear();
            textboxInsertionSensorB.Clear();
        }
        #endregion
    }
}
