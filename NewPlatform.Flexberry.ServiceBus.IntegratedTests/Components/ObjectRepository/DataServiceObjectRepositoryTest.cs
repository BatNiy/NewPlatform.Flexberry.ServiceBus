﻿namespace NewPlatform.Flexberry.ServiceBus.IntegratedTests.Components
{
    using System.Collections.Generic;
    using System.Linq;
    using Flexberry.ServiceBus.Components;
    using ICSSoft.STORMNET;
    using Xunit;

    /// <summary>
    /// Tests for DataServiceObjectRepository component.
    /// </summary>
    public class DataServiceObjectRepositoryTest : BaseServiceBusIntegratedTest
    {
        public DataServiceObjectRepositoryTest()
            : base("CObjRepo")
        {
        }

        /// <summary>
        /// Testing GetAllServiceBuses method with empty and non-empty data.
        /// </summary>
        /// <param name="buses">
        /// Test Collection of Service Buses.
        /// </param>
        [Theory]
        [MemberData("BusesData")]
        public void TestGetAllServiceBuses(IEnumerable<DataObject> buses)
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                var objsToUpdate = buses.ToArray();
                if (objsToUpdate.Length > 0)
                {
                    dataService.UpdateObjects(ref objsToUpdate);
                }

                // Reset DataObjects status
                foreach (var item in objsToUpdate)
                {
                    item.Prototyping(false);
                }

                var component = new DataServiceObjectRepository(dataService, GetMockStatisticsService());

                // Act.
                var actualList = component.GetAllServiceBuses();

                // Assert.
                Assert.Equal(objsToUpdate.Length, actualList.Count());

                if (objsToUpdate.Length > 0)
                {
                    ObjectRepositoryTestHelper.CheckPropertiesOfAllObjects(actualList, objsToUpdate, new[] { "ID", "Name", "ManagerAddress" });
                }
            }
        }

        /// <summary>
        /// Testing GetAllMessageTypes method with empty and non-empty data.
        /// </summary>
        /// <param name="messageTypes">
        /// Test Collection of Message Types.
        /// </param>
        [Theory]
        [MemberData("MessageTypesData")]
        public void TestGetAllMessageTypes(IEnumerable<DataObject> messageTypes)
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                var objsToUpdate = messageTypes.ToArray();
                if (objsToUpdate.Length > 0)
                {
                    dataService.UpdateObjects(ref objsToUpdate);
                }

                // Reset DataObjects status
                foreach (var item in objsToUpdate)
                {
                    item.Prototyping(false);
                }

                var component = new DataServiceObjectRepository(dataService, GetMockStatisticsService());

                // Act.
                var actualList = component.GetAllMessageTypes();

                // Assert.
                Assert.Equal(objsToUpdate.Length, actualList.Count());

                if (objsToUpdate.Length > 0)
                {
                    ObjectRepositoryTestHelper.CheckPropertiesOfAllObjects(actualList, objsToUpdate, new[] { "ID", "Name" });
                }
            }
        }

        /// <summary>
        /// Testing GetAllRestrictions method with empty and non-empty data.
        /// </summary>
        /// <param name="sendingPermissions">
        /// Test Collection of Outbound Message Type Restrictions.
        /// </param>
        [Theory]
        [MemberData("SendingPermissionsData")]
        public void TestGetAllRestrictions(IEnumerable<DataObject> sendingPermissions)
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                var sendingPermissionsArray = sendingPermissions.ToArray();

                if (sendingPermissionsArray.Length > 0)
                {
                    var client1 = ((SendingPermission)sendingPermissionsArray[0]).Client;
                    var client2 = ((SendingPermission)sendingPermissionsArray[1]).Client;
                    var messageType1 = ((SendingPermission)sendingPermissionsArray[0]).MessageType;
                    var messageType2 = ((SendingPermission)sendingPermissionsArray[1]).MessageType;
                    DataObject[] objsToUpdate =
                    {
                        client1, client2, messageType1, messageType2,
                        sendingPermissionsArray[0], sendingPermissionsArray[1]
                    };

                    dataService.UpdateObjects(ref objsToUpdate);

                    // Reset DataObjects status
                    foreach (var item in objsToUpdate)
                    {
                        item.Prototyping(false);
                    }
                }

                var component = new DataServiceObjectRepository(dataService, GetMockStatisticsService());

                // Act.
                var actualList = component.GetAllRestrictions();

                // Assert.
                Assert.Equal(sendingPermissionsArray.Length, actualList.Count());

                if (sendingPermissionsArray.Length > 0)
                {
                    ObjectRepositoryTestHelper.CheckPropertiesOfAllObjects(actualList, sendingPermissionsArray, new[] { "Client.ID" });
                }
            }
        }

        /// <summary>
        /// Testing GetRestrictionsForClient method with empty and non-empty data.
        /// </summary>
        /// <param name="sendingPermissions">
        /// Test Collection of Outbound Message Type Restrictions.
        /// </param>
        [Theory]
        [MemberData("SendingPermissionsData")]
        public void TestGetRestrictionsForClient(IEnumerable<DataObject> sendingPermissions)
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                var clientId = "SomeClient ID";
                var sendingPermissionsArray = sendingPermissions.ToArray();

                if (sendingPermissionsArray.Length > 0)
                {
                    var client1 = ((SendingPermission)sendingPermissionsArray[0]).Client;
                    var client2 = ((SendingPermission)sendingPermissionsArray[1]).Client;
                    var messageType1 = ((SendingPermission)sendingPermissionsArray[0]).MessageType;
                    var messageType2 = ((SendingPermission)sendingPermissionsArray[1]).MessageType;
                    DataObject[] objsToUpdate =
                    {
                        client1, client2, messageType1, messageType2,
                        sendingPermissionsArray[0], sendingPermissionsArray[1]
                    };

                    clientId = client1.ID;

                    dataService.UpdateObjects(ref objsToUpdate);

                    // Reset DataObjects status
                    foreach (var item in objsToUpdate)
                    {
                        item.Prototyping(false);
                    }
                }

                var component = new DataServiceObjectRepository(dataService, GetMockStatisticsService());

                // Act.
                var actualList = component.GetRestrictionsForClient(clientId);

                // Assert.
                Assert.Equal(sendingPermissionsArray.Length > 0 ? 1 : 0, actualList.Count());

                if (sendingPermissionsArray.Length > 0)
                {
                    var isActualListContainsRectriction = actualList.Count(r => r.Client.ID == clientId) == 1;
                    Assert.True(isActualListContainsRectriction);
                }
            }
        }

        /// <summary>
        /// Testing GetRestrictionsForMsgType method with empty and non-empty data.
        /// </summary>
        /// <param name="sendingPermissions">
        /// Test Collection of Outbound Message Type Restrictions.
        /// </param>
        [Theory]
        [MemberData("SendingPermissionsData")]
        public void TestGetRestrictionsForMsgType(IEnumerable<DataObject> sendingPermissions)
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                var messageTypeId = "Some MessageType ID";
                var sendingPermissionsArray = sendingPermissions.ToArray();

                if (sendingPermissionsArray.Length > 0)
                {
                    var client1 = ((SendingPermission)sendingPermissionsArray[0]).Client;
                    var client2 = ((SendingPermission)sendingPermissionsArray[1]).Client;
                    var messageType1 = ((SendingPermission)sendingPermissionsArray[0]).MessageType;
                    var messageType2 = ((SendingPermission)sendingPermissionsArray[1]).MessageType;
                    DataObject[] objsToUpdate =
                    {
                        client1, client2, messageType1, messageType2,
                        sendingPermissionsArray[0], sendingPermissionsArray[1]
                    };

                    messageTypeId = messageType2.ID;

                    dataService.UpdateObjects(ref objsToUpdate);

                    // Reset DataObjects status
                    foreach (var item in objsToUpdate)
                    {
                        item.Prototyping(false);
                    }
                }

                var component = new DataServiceObjectRepository(dataService, GetMockStatisticsService());

                // Act.
                var actualList = component.GetRestrictionsForMsgType(messageTypeId);

                // Assert.
                Assert.Equal(sendingPermissionsArray.Length > 0 ? 1 : 0, actualList.Count());

                if (sendingPermissionsArray.Length > 0)
                {
                    var isActualListContainsRectriction = actualList.Count(r => r.MessageType.ID == messageTypeId) == 1;
                    Assert.True(isActualListContainsRectriction);
                }
            }
        }

        private static IEnumerable<object[]> BusesData()
        {
            yield return new object[]
            {
                new List<Bus>
                {
                    new Bus() { ID = "Bus 1", Name = "Bus name 1", ManagerAddress = "http://localhost:12343/SBService" },
                    new Bus() { ID = "Bus 2", Name = "Bus name 2", ManagerAddress = "http://localhost:12344/SBService" }
                }
            };

            yield return new object[]
            {
                new List<Bus>(0)
            };
        }

        private static IEnumerable<object[]> MessageTypesData()
        {
            yield return new object[]
            {
                new List<MessageType>
                {
                    new MessageType() { ID = "Message type 1", Name = "Message type name 1" },
                    new MessageType() { ID = "Message type 2", Name = "Message type name 2" }
                }
            };

            yield return new object[]
            {
                new List<MessageType>(0)
            };
        }

        private static IEnumerable<object[]> SendingPermissionsData()
        {
            var client1 = new Client() { ID = "Client 1", Name = "Client name 1" };
            var client2 = new Client() { ID = "Client 2", Name = "Client name 2" };
            var messageType1 = new MessageType() { ID = "Message type 1", Name = "Message type name 1" };
            var messageType2 = new MessageType() { ID = "Message type 2", Name = "Message type name 2" };

            var sendingPermission1 = new SendingPermission() { Client = client1, MessageType = messageType1 };
            var sendingPermission2 = new SendingPermission() { Client = client2, MessageType = messageType2 };

            yield return new object[]
            {
                new List<SendingPermission>() { sendingPermission1, sendingPermission2 }
            };

            yield return new object[]
            {
                new List<SendingPermission>(0)
            };
        }
    }
}
