namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int _top; // Logic size
        private int[] _array;

        public OneDimension(int n)
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        /// <summary>
        /// Indicates if the array is empty
        /// </summary>
        public bool IsEmpty => _top == 0;

        /// <summary>
        /// Indicates if the array is full
        /// </summary>
        public bool IsFull => _top == N;

        /// <summary>
        /// Physical size of the array
        /// </summary>
        public int N { get; } // Physical size

        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

        

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Empty array.";
            }

            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if (count > 15)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }

    }
}