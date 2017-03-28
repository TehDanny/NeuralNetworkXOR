using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkXOR
{
    class NeuralLayer : INeuralLayer
    {
        private int count;
        private bool isReadOnly;
        List<INeuron> m_neurons;

        public INeuron this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public bool IsReadOnly
        {
            get { return isReadOnly; }
            set { isReadOnly = value; }
        }

        public void Add(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void ApplyLearning(INeuralNet net)
        {
            foreach (INeuron n in m_neurons)
                n.ApplyLearning(this);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(INeuron[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<INeuron> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, INeuron item)
        {
            throw new NotImplementedException();
        }

        public void Pulse(INeuralNet net)
        {
            foreach (INeuron n in m_neurons)
                n.Pulse(this);
        }

        public bool Remove(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
