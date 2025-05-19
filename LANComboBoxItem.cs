using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANSpeed
{
    internal class LANComboBoxItem
    {
        String id;
        String modelName;
        String networkName;


        public LANComboBoxItem(string id, string modelName, string networkName)
        {
            this.id = id;
            this.modelName = modelName;
            this.networkName = networkName;
        }

        public String lanId()
        {
            return id;
        }

        public override String ToString()
        {
            return modelName + " (" + networkName + ")";
        }
    }
}
