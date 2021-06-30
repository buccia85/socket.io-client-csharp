﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SocketIOClient.Test.SocketIOTests.V2
{
    [TestClass]
    public class DisconnectionV2Test : DisconnectionTest
    {
        public DisconnectionV2Test()
        {
            SocketIOCreator = new ScoketIOV2Creator();
        }

        protected override ISocketIOCreateable SocketIOCreator { get; }

        [TestMethod]
        public override async Task Test()
        {
            await base.Test();
        }
    }
}