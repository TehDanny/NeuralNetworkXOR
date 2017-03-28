using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkXOR
{
    class Neuron : INeuron
    {
        #region Constructors

        public Neuron()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Variables

        private NeuralFactor m_bias;
        private double m_biasWeight;
        private double m_error;
        private Dictionary<INeuronSignal, NeuralFactor> m_input;
        private double m_output;

        #endregion

        #region Properties

        public NeuralFactor Bias
        {
            get { return m_bias; }
            set { m_bias = value; }
        }

        public double BiasWeight
        {
            get { return m_biasWeight; }
            set { m_biasWeight = value; }
        }

        public double Error
        {
            get { return m_error; }
            set { m_error = value; }
        }

        public Dictionary<INeuronSignal, NeuralFactor> Input
        {
            get { return m_input; }
            set { m_input = value; }
        }

        public double Output
        {
            get { return m_output; }
            set { m_output = value; }
        }
        #endregion

        #region Methods

        public void ApplyLearning(INeuralLayer layer)
        {
            throw new NotImplementedException();
        }

        public void Pulse(INeuralLayer layer)
        {
            lock(this)
            {
                m_output = 0;

                foreach (KeyValuePair<INeuronSignal, NeuralFactor> item in m_input)
                    m_output += item.Key.Output * item.Value.Weight;

                m_output += m_bias.Weight * BiasWeight;

                m_output = Sigmoid(m_output);
            }
        }

        private static double Sigmoid(double value)
        {
            return 1 / (1 + Math.Exp(-value));
        }

        #endregion
    }
}
