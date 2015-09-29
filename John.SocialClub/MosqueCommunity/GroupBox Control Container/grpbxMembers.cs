using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.GroupBox_Control_Container
{
  public  class grpbxMembers
    {
        public grpbxMembers(BaseForm ContainerForm)
        {
            ContainerForm.grpbxMembers = new System.Windows.Forms.GroupBox();

            ContainerForm.grpbxMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
          | System.Windows.Forms.AnchorStyles.Right)
      ));
            ContainerForm.grpbxMembers.Location = new System.Drawing.Point(0, 1);
            ContainerForm.grpbxMembers.Name = "grpbxMembers";
            ContainerForm.grpbxMembers.Size = new System.Drawing.Size(722, 531);
            ContainerForm.grpbxMembers.TabIndex = 3;
            ContainerForm.grpbxMembers.TabStop = false;
            ContainerForm.grpbxMembers.Text = "Members";
            ContainerForm.Controls.Add(ContainerForm.grpbxMembers);
            //ContainerForm.showControls.Add(ContainerForm.trvwMainTree.Nodes.Find("ndReport", true)[0], ContainerForm.grpbxReportMembers);
        }
    }
}
