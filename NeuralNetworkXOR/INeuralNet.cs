using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkXOR
{
    public interface INeuralNet
    {
        INeuralLayer HiddenLayer { get; set; }
        INeuralLayer OutputLayer { get; set; }
        INeuralLayer PerceptionLayer { get; set; }

        double LearningRate { get; set; }

        void ApplyLearning();
        void Pulse();
    }
}
