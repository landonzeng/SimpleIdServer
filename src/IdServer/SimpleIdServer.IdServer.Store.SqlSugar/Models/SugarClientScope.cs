﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using SqlSugar;

namespace SimpleIdServer.IdServer.Store.SqlSugar.Models;

[SugarTable("ClientScope")]
public class SugarClientScope
{
    [SugarColumn(IsPrimaryKey = true)]
    public string ClientsId { get; set; }
    [SugarColumn(IsPrimaryKey = true)]
    public string ScopesId {  get; set; }
    [Navigate(NavigateType.ManyToOne, nameof(ScopesId))]
    public SugarScope Scope { get; set; }
}
