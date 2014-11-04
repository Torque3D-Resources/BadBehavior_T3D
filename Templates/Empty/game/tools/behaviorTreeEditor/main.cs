function reloadBTE()
{
   if(isObject(BehaviorTreeEditorGui))
      BehaviorTreeEditorGui.delete();
      
   initializeBehaviorTreeEditor();
}

function initializeBehaviorTreeEditor()
{
   echo( " % - Initializing Behavior Tree Editor" );
   
   // exec the scripts and gui
   exec("./scripts/behaviorTreeEditorProfiles.ed.cs");
   exec("./gui/behaviorTreeEditor.ed.gui");
   exec("./scripts/behaviorTreeEditorCanvas.ed.cs");
   exec("./scripts/behaviorTreeEditor.ed.cs");
   exec("./scripts/behaviorTreeEditorUndo.ed.cs");
   exec("./scripts/behaviorTreeEditorStatusBar.ed.cs");
   exec("./scripts/behaviorTreeEditorContentList.ed.cs");
   exec("./scripts/behaviorTreeEditorInspector.ed.cs");
   
   // This isn't pretty, but we need to load up existing trees
   if(!isObject(BehaviorTreeManager))
      exec("scripts/server/behaviorTreeManager.cs");

   // register the class icons
   EditorIconRegistry::loadFromPath("tools/behaviorTreeEditor/images/classIcons/");
}

function destroyBehaviorTreeEditor()
{
}
