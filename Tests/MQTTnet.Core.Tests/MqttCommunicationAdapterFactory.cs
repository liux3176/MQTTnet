﻿using MQTTnet.Core.Adapter;
using MQTTnet.Core.Channel;
using MQTTnet.Core.Client;

namespace MQTTnet.Core.Tests
{
    public class MqttCommunicationAdapterFactory : IMqttCommunicationAdapterFactory
    {
        private readonly IMqttCommunicationAdapter _adapter;

        public MqttCommunicationAdapterFactory(IMqttCommunicationAdapter adapter)
        {
            _adapter = adapter;
        }

        public IMqttCommunicationAdapter CreateClientCommunicationAdapter(IMqttClientOptions options)
        {
            return _adapter;
        }

        public IMqttCommunicationAdapter CreateServerCommunicationAdapter(IMqttCommunicationChannel channel)
        {
            return _adapter;
        }
    }
}
