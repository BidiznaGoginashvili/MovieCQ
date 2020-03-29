﻿using System;

namespace Movie.Application.Infrastructure
{
    public class ExecutionResult
    {
        public bool Success { get; set; }

        public Exception Exception { get; set; }
    }

    public class CommandExecutionResult : ExecutionResult
    {
        public object Data { get; set; }
    }

    public class QueryExecutionResult<TResult> : ExecutionResult
    {
        public TResult Data { get; set; }
    }
}
