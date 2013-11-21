using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Managers
{
    public class ManageBase
    {
        // most managers will require a resource accessors and engines so we are putting these properties in the base class
        // note: we are using a property instead of passing these dependencies in via the method calls

        private IAccessorFactory _accessorFactory = new AccessorFactory();
        public IAccessorFactory AccessorFactory
        {
            get { return _accessorFactory; }
            set { _accessorFactory = value; }
        }

        //private IEngineFactory _engineFactory = new EngineFactory();
        //public IEngineFactory EngineFactory
        //{
        //    get { return _engineFactory; }
        //    set { _engineFactory = value; }
        //}
    }
}
