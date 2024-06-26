﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Stores;

public interface ITransactionBuilder
{
    ITransaction Build();
}


public interface ITransaction : IDisposable
{
    Task<int> Commit(CancellationToken cancellationToken);
}