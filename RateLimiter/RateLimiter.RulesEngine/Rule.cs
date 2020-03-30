using System;
using System.Collections.Generic;

namespace RateLimiter.RulesEngine
{
    public abstract class Rule {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public RateLimitType RateLimitType { get; private set; }
        public RateLimitLevel RateLimitLevel { get; private set; }

        public Rule(int id, string name, RateLimitType rateLimitType, RateLimitLevel rateLimitLevel) {
            this.Id = id;
            this.Name = name;
            this.RateLimitType = rateLimitType;
            this.RateLimitLevel = rateLimitLevel;
        }
    }

    public class ResourceRule : Rule {
        public ResourceRule(int id, string name, RateLimitType rateLimitType, RateLimitLevel rateLimitLevel)
            : base(id, name, rateLimitType, rateLimitLevel) {
        }
    }
}