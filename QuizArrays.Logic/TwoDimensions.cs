namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _matrix;
        private int _m; // rows
        private int _n; // columns

        public TwoDimensions()
        {
            _n = 10;
            _m = 10;
            _matrix = new int[_m, _n];
        }

        public TwoDimensions(int n)
        {
            _n = n;
            _m = n;
            _matrix = new int[_m, _n];
        }

        public TwoDimensions(int m, int n)
        {
            _n = n;
            _m = m;
            _matrix = new int[_m, _n];
        }

        public int M => _m;
        public int N => _n;

        public void Fill()
        {
            Fill(1, 100);
        }

        public void Fill(int min, int max)
        {
            var random = new Random();
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrix[i, j] = random.Next(min, max);
                }
            }
        }

        public OneDimension ToOneDimension()
        {
            int sizeVector = M * N;
            var oneDimension = new OneDimension(sizeVector);

            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    oneDimension.Add(_matrix[i, j]);
                }
            }

            return oneDimension;
        }


        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    output += $"{_matrix[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }


    }
}
