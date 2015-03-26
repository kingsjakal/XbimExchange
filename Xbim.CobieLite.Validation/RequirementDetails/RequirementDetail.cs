﻿namespace Xbim.CobieLite.Validation.RequirementDetails
{
    public class RequirementDetail
    {
        public enum EvaluationCriterion
        {
            IgnoreValue,
            ExactMatch,
            MinumumValue,
            MaximumValue
        }

        public string Name;
        public string Description;
        public EvaluationCriterion Criterion = EvaluationCriterion.IgnoreValue;

        public RequirementDetail(COBieLiteUK.Attribute attrib)
        {
            Name = attrib.Name;
            Description = attrib.Description;
        }
    }
}