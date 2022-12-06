namespace Table
{
    public class Table<T>
    {
        T[,] data;

        public Table(int rows, int columns)
        {
            data = new T[rows, columns];
        }

        public T this[int index1, int index2]
        {
            get => data[index1, index2];
            set => data[index1, index2] = value;
        }

        public void ShowFullTable()
        {

        }

        public void AddColumns(int num) //num это кол-во добавляемых столбцов
        {

        }

        public void AddRows(int num) //num это кол-во добавляемых строк
        {

        }
    }

    // Я написал этот коментарий в школе

}
