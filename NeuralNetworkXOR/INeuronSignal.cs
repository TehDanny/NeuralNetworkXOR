using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkXOR
{
    public interface INeuronSignal
    {
        double Output { get; set; }
    }
}
