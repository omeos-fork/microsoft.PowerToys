// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using AOTTestApp;
using Microsoft.PowerToys.Telemetry;

Console.WriteLine("Hello, World!");

Console.WriteLine("Before write event");

PowerToysTelemetry.Log.WriteEvent(new TestEvent() { AssignmentContext = "TestContext", ClientID = "TestClientID" });

Console.WriteLine("After write event");

// Get the user input
Console.WriteLine("Please enter your name:");
string? name = Console.ReadLine();
