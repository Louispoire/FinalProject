   M S B A M L   `   `   `  ����P  LContactManagerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ContactManagerProject.ViewsContactManagerProject.Views  5      .    (ContactManagerProject.Views.ShowAllUsers   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ContactManagerProject.Views     5      .��5      � ���	#FFE8C15F$	��574��6"   $	��692��6/   .+�5   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dataDisplay��5   �      AutoGenerateColumns .  $	��259��6/   $��Center=�6<      AlternatingRowBackground �	#FFE48CA9$
��Bold"�6~   $��25,185,467,0q�6�   $	��Top=�6�   $	��200��6�      RowBackground �	#FF7ABBF3{�.  ��6�   �� *dataBinding+   Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6<      Header$ ID��6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+6H     5      $	 100 6>   $
 Name��6J    6%   �� *name+6J   5      �� 5   
   $��	All Users��6   $
��Left=�6$   $	��Top=�6?   $��50(�6W   $��74��6e   $	��218��6q   $
��Bold"�6}   ���	#FFDEAD30$��
207,14,0,0q�6�   �� 5   
   -   5         ��Name$ ShowAll��5   `   $��Show All��6   $��54��6$   $
��Left=�60   $��231,118,0,0q�6K   $	��Top=�6q   $	��140��6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	DeleteAll��5   b   $��
Delete All��6   $��54��6&   $
��Left=�62   $��231,453,0,0q�6M   $	��Top=�6u   $	��140��6�   	 J� RenderTransformOrigin$	 -0.533,1.706&�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $
 View��5       $
��View��6   $��54��6.   $��267,213,347,307q�6M   $��20(�6f   $
��Bold"�6t   $	 0.006,0.556&�6�   �� 5   
   -   5        
 ��Name$
 viewBox��5      $��60��6#   $��237,318,317,196q�6/   $��40(�6H    �� TextAlignment$ Center=�6V   �� 5   
   -   5         ��Name$ displayView��5      $��388,185,93,130q�6)   ���	#FFDEAD30$��20(�6X   $
��Bold"�6f    �� TextAlignment$ Justify=�6x   5      5      