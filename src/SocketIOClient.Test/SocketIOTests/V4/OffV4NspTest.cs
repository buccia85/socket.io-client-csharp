﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SocketIOClient.Test.SocketIOTests.V4
{
    [TestClass]
    public class OffV4NspTest : OffTest
    {
        public OffV4NspTest()
        {
            SocketIOCreator = new ScoketIOV4NspCreator();
        }

        protected override ISocketIOCreateable SocketIOCreator { get; }

        [TestMethod]
        public override async Task Test()
        {
            await base.Test();
        }
    }
}
