namespace OperatorOverloadPractickalWork
{
    public class Table
    {
        public string Material { get; set; }
        public int Height { get; set; }
        public string Model { get; set; }

        public static string operator ==(Table firstTable, Table secondTable)
        {
            string result;
            int numberOfCoincidences = 0;
            if (firstTable.Material == secondTable.Material)
            {
                numberOfCoincidences++;
            }

            if (firstTable.Height == secondTable.Height)
            {
                numberOfCoincidences++;
            }

            if (firstTable.Model == secondTable.Model)
            {
                numberOfCoincidences++;
            }

            if(numberOfCoincidences == 3)
            {
                result = "объекты одинаковые";
            }
            else
            {
                result = "объекты неодинаковые";
            }
            return result;
        }

        public static string operator !=(Table firstTable, Table secondTable)
        {
            string result;
            int numberOfDifferences = 0;
            if (firstTable.Material != secondTable.Material)
            {
                numberOfDifferences++;
            }

            if (firstTable.Height != secondTable.Height)
            {
                numberOfDifferences++;
            }

            if (firstTable.Model != secondTable.Model)
            {
                numberOfDifferences++;
            }

            if(numberOfDifferences == 3)
            {
                result = "объекты разные";
            }
            else
            {
                result = "объекты неразные";
            }
            return result;
        }
    }
}