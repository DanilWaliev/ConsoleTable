namespace Table
{
    public class Table<T>
    {
        T[,] data;

        public Table(int columns, int rows)
        {
            data = new T[columns, rows];
        }

        public T this[int index1, int index2]
        {
            get => data[index1, index2];
            set => data[index1, index2] = value;
        }
    }
}
