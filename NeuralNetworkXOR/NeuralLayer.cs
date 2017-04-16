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
        private List<INeuron> m_neurons;

        public INeuron this[int index]
        {
            get { return m_neurons[index]; }
            set { m_neurons[index] = value; }
        }

        public NeuralLayer()
        {
            m_neurons = new List<INeuron>();
        }

        public int Count
        {
            get { return m_neurons.Count; }
        }

        public bool IsReadOnly
        {
            get { return isReadOnly; }
            set { isReadOnly = value; }
        }

        public void Add(INeuron item)
        {
            m_neurons.Add(item);
        }

        public void ApplyLearning(INeuralNet net)
        {
            double learningRate = net.LearningRate;

            foreach (INeuron n in m_neurons)
                n.ApplyLearning(this, ref learningRate);
        }

        public void Clear()
        {
            m_neurons.Clear();
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
