   M S B A M L   `   `   `  ����P  LContactManagerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ContactManagerProjectContactManagerProject  5   	   S.clr-namespace:ContactManagerProject.ViewModels ContactManagerProject.ViewModels  5   	   I)clr-namespace:ContactManagerProject.ViewsContactManagerProject.Views  5   	   &     ContactManagerProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ContactManagerProject     5   	   E
viewmodels.clr-namespace:ContactManagerProject.ViewModels     5   	   ;views)clr-namespace:ContactManagerProject.Views     5   	   -   5          �Name$  	FrmWindow��5   	    � Title$ Contact Manager System��5
      $	��506��60   $	��763��6=    � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$
 None=�6�    � 	Resources 5       �� DataType3   -ContactManagerProject.ViewModels.AddUserModel)   #ContactManagerProject.Views.AddUser � DataContext8   2ContactManagerProject.ViewModels.ShowAllUsersModel.   (ContactManagerProject.Views.ShowAllUsers6  0ContactManagerProject.ViewModels.DeleteUserModel,   &ContactManagerProject.Views.DeleteUser6  0ContactManagerProject.ViewModels.UpdateUserModel,   &ContactManagerProject.Views.UpdateUser7	   1ContactManagerProject.ViewModels.ImportUsersModel-
   'ContactManagerProject.Views.ImportUsers7  1ContactManagerProject.ViewModels.ExportUsersModel-   'ContactManagerProject.Views.ExportUsers��%�  (��       5   ,   *, +)(�� P     5   0   *, +)(�� �     5   /   *, +)(�� �     5   /   *, +)(�� J    5   /   *,	 +)(�� �    5   /   *, +)�� 5   
   addTemplate��"  6,   .R�5         6   �� 5      �� 5   
   showAllTemplate��"  60   .R�5         6!   �� 5      �� 5   
   deleteTemplate��"  6/   .R�5         6   �� 5      �� 5   
   updateTemplate��"  6/   .R�5         6   �� 5      �� 5   
   importTemplate��" 	 6/   .R�5      
   6    �� 5      �� 5   
   exportTemplate��"  6/   .R�5         6    �� 5      5      .��5       � ���#474747 � ColumnDefinitions 5"   
   �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      	 � RowDefinitions	 5)   
   �� 5*      �� 5+      �� 5,      �� 5-      �� 5.      .+�51   
   �� -   5        
 ��Name$
 
lblWelcome��51      $��1��6$   $��1��64   $��3��6A   $��4��6R   $*��$Welcome To 
Database Pro Analysis™��6f   $��40(�6�   $��	ExtraBold"�6�   
�������&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   �� 52   
   -   5        $
 lblWelcome1��52      $��1��6%   $��2��65   $��3��6B   $��4��6S   $��V.4.05��6g   $��30(�6x   $��	ExtraBold"�6�   
�������$ Display=�6�   ]� 55   
   
�������$��0��6*   $��0��67   $��5��6G   .+�56      �� $��5��6   .+�57      �� -   5         ��Name$
 menu��57   (   $��51��6   $
��Menu��66   $	��Top=�6B   $��34(�6Z   $	��101��6h   $
��Bold"�6t   �� 58      -   5        $��Add Contact��58      $��40��6/   6<   �� 59      -   5        $��Show All Contact��59      $��40��64   6@   �� 5:      -   5        $��Update Contact��5:      $��40��62   6>   �� 5;      -   5        $��Delete Contact��5;      $��40��62   6>   �� 5<      -	   5        $��Import��5<      $��40��6*   66   �� 5=      -
   5        $��Export��5=      $��40��6*   66   �� 5>      -   5        $
 info��5>   (   $��98��6   $A��;Created by
 Louis-Philippe Simard 
 and 
 Cristian Cantillo��66   $	��Top=�6�   $��10(�6�   $	��143��6�   $
��Bold"�6�   �� 5?      -   5        $
��Quit��5?      $��40��6(   $��	0,80,0,0 q�64   6G   5@      5A      �� 5E   
   $��0��6   $��1��6&   $��4��66   $��5��6J   ��6[   �� 5K      5L      