// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.CodeFixes
{
    /// <summary>
    /// Fix multiple occurrences code action.
    /// </summary>
    internal partial class FixMultipleCodeAction : FixSomeCodeAction
    {
        private readonly Diagnostic _triggerDiagnostic;
        private readonly string _title;
        private readonly string _computingFixWaitDialogMessage;

        internal FixMultipleCodeAction(
            FixAllState fixAllState,
            Diagnostic triggerDiagnostic,
            string title,
            string computingFixWaitDialogMessage)
            : base(fixAllState, showPreviewChangesDialog: false)
        {
            _triggerDiagnostic = triggerDiagnostic;
            _title = title;
            _computingFixWaitDialogMessage = computingFixWaitDialogMessage;
        }

        public Diagnostic GetTriggerDiagnostic() => _triggerDiagnostic;

        public override string Title => _title;
        internal override string Message => _computingFixWaitDialogMessage;
    }
}