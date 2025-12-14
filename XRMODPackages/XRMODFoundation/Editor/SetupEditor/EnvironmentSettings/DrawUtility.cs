using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public static class DrawUtility
    {
        public static VisualElement CreateSettingStateUI(string _title, string _errorHelp, Func<bool> _checkAction, Texture _checked,
            Texture _error, Action _fixAction = null, Action<VisualElement> _drawExtUI = null)
        {
            var tmp_Container = new VisualElement();
            
            // Row Container
            var tmp_Row = new VisualElement();
            tmp_Row.AddToClassList("validation-row");
            tmp_Container.Add(tmp_Row);

            // Left Content (Icon + Label)
            var tmp_Content = new VisualElement();
            tmp_Content.AddToClassList("validation-content");
            tmp_Row.Add(tmp_Content);

            var tmp_StatusIcon = new Image();
            // Default to checked or a distinct "loading" icon? 
            // For now, let's start with checked (optimistic) or null.
            // If we use _checked, it might flicker. 
            // Let's use _checked as default to avoid layout shift, or maybe a neutral state if available.
            // Using _checked for now as "pending".
            tmp_StatusIcon.image = _checked; 
            tmp_StatusIcon.AddToClassList("status-icon");
            tmp_Content.Add(tmp_StatusIcon);

            var tmp_Label = new Label(_title);
            tmp_Label.AddToClassList("row-label");
            tmp_Content.Add(tmp_Label);

            Action tmp_PerformCheck = () =>
            {
                // Random delay between 0 and 100ms to spread the load across frames
                long tmp_Delay = (long)(UnityEngine.Random.Range(0f, 0.1f) * 1000);

                // check if still attached? 
                // When reused from cache, it might not be attached yet or just re-attached.
                // It's safer to just run.
                
                // Reset to pending/loading state if needed? 
                // Or just keep current state until check finishes.
                
                tmp_Container.schedule.Execute(() =>
                {
                   if (tmp_Container.panel == null) return; 

                    bool tmp_Result = _checkAction != null && _checkAction.Invoke();
                    
                    // Update UI on main thread
                    tmp_StatusIcon.image = tmp_Result ? _checked : _error;

                    var tmp_ExistingFixBtn = tmp_Container.Q(null, "fix-button");
                    var tmp_ExistingHelpBox = tmp_Container.Q(null, "help-box");

                    if (!tmp_Result)
                    {
                        if (tmp_ExistingFixBtn == null)
                        {
                            Button tmp_FixBtn = null;
                            tmp_FixBtn = new Button(() =>
                            {
                                _fixAction?.Invoke();
                                
                                // Optimistic update
                                tmp_StatusIcon.image = _checked;
                                if (tmp_FixBtn != null) tmp_FixBtn.RemoveFromHierarchy();
                                var tmp_Help = tmp_Container.Q(null, "help-box");
                                if (tmp_Help != null) tmp_Help.RemoveFromHierarchy();
                            }) {text = "Fix"};
                            
                            tmp_FixBtn.AddToClassList("fix-button");
                            tmp_Row.Add(tmp_FixBtn);
                        }

                        if (tmp_ExistingHelpBox == null)
                        {
                            var tmp_HelpBox = new VisualElement();
                            tmp_HelpBox.AddToClassList("help-box");
                            
                            var tmp_HelpLabel = new Label(_errorHelp);
                            tmp_HelpLabel.AddToClassList("help-box-label");
                            tmp_HelpBox.Add(tmp_HelpLabel);
                            
                            tmp_Container.Add(tmp_HelpBox);

                            _drawExtUI?.Invoke(tmp_Container);
                        }
                    }
                    else
                    {
                        // Passed
                        if (tmp_ExistingFixBtn != null) tmp_ExistingFixBtn.RemoveFromHierarchy();
                        if (tmp_ExistingHelpBox != null) tmp_ExistingHelpBox.RemoveFromHierarchy();

                        // Ensure spacer is there if needed? 
                        // Simplified: assuming spacer management is not critical or adding multiple spacers is fine (flexbox handles it).
                    }
                }).StartingIn(tmp_Delay);
            };

            // Store the check action in userData so we can call it later when reusing the element
            tmp_Container.userData = tmp_PerformCheck;

            // Trigger first check
            tmp_PerformCheck.Invoke();

            return tmp_Container;
        }

        // Keep old method for backward compatibility if needed, or remove if fully successfully migrated.
        // For now, I will comment it out or leave it if there are other usages not tracked.
        // Looking at the codebase, it seems only used here. I'll replace the content entirely.
    }
}