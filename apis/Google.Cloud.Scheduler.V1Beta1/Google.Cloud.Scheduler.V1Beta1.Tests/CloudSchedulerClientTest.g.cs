// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Scheduler.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Scheduler.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedCloudSchedulerClientTest
    {
        [Fact]
        public void GetJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.GetJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = client.GetJob(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = await client.GetJobAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.GetJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            CreateJobRequest expectedRequest = new CreateJobRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.CreateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Job job = new Job();
            Job response = client.CreateJob(formattedParent, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            CreateJobRequest expectedRequest = new CreateJobRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Job job = new Job();
            Job response = await client.CreateJobAsync(formattedParent, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.CreateJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            UpdateJobRequest expectedRequest = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.UpdateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job job = new Job();
            FieldMask updateMask = new FieldMask();
            Job response = client.UpdateJob(job, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            UpdateJobRequest expectedRequest = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job job = new Job();
            FieldMask updateMask = new FieldMask();
            Job response = await client.UpdateJobAsync(job, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.UpdateJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            client.DeleteJob(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            await client.DeleteJobAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PauseJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            PauseJobRequest expectedRequest = new PauseJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.PauseJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = client.PauseJob(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PauseJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            PauseJobRequest expectedRequest = new PauseJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.PauseJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = await client.PauseJobAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PauseJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.PauseJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.PauseJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PauseJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.PauseJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.PauseJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ResumeJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            ResumeJobRequest expectedRequest = new ResumeJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.ResumeJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = client.ResumeJob(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ResumeJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            ResumeJobRequest expectedRequest = new ResumeJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.ResumeJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = await client.ResumeJobAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ResumeJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.ResumeJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.ResumeJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ResumeJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.ResumeJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.ResumeJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RunJob()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            RunJobRequest expectedRequest = new RunJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.RunJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = client.RunJob(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunJobAsync()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            RunJobRequest expectedRequest = new RunJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.RunJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            string formattedName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString();
            Job response = await client.RunJobAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RunJob2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.RunJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.RunJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunJobAsync2()
        {
            Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new Mock<CloudScheduler.CloudSchedulerClient>(MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                Name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]").ToString(),
            };
            Job expectedResponse = new Job
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Schedule = "schedule-697920873",
                TimeZone = "timeZone36848094",
            };
            mockGrpcClient.Setup(x => x.RunJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.RunJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
