using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiboPlaygroud
{
    public class ArrayFormatter
    {
        private readonly int[] _objects;
        private readonly int _lineWidth;

        private StringBuilder _output;
        public ArrayFormatter(int[] objects, int lineWidth)
        {
            _objects = objects;
            _lineWidth = lineWidth;
        }

        public override string ToString()
        {
            _output = new StringBuilder();
            var maxObjectWidth = GetObjectMaxLength();
            var numberOfObjectsPerLine = _lineWidth/(maxObjectWidth + 1);
            var objectNumber = 1;
            foreach (var o in _objects)
            {
                var tmp = o.ToString();
                var space = maxObjectWidth - tmp.Length;
                _output.Append($"{tmp}{GetWhiteSpace(space + 1)}");
                if (objectNumber++ == numberOfObjectsPerLine)
                {
                    objectNumber = 1;
                    _output.AppendLine();
                }
            }
            return _output.ToString();
        }

        private string GetWhiteSpace(int count)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < count; i++)
                sb.Append(" ");
            return sb.ToString();
        }

        private int GetObjectMaxLength()
        {
            return _objects.Max(o => o.ToString().Length);
        }
    }
}