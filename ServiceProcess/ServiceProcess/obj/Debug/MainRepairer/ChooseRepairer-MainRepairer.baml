   M S B A M L   `   `   `  ����I  EServiceProcess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServiceProcessServiceProcess  5   	   0    *ServiceProcess.ChooseRepairer_MainRepairer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServiceProcess     5   	     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � Title$ Choose a repairer��5   	   $	��710��6#   $	��800��60   .��5	      � .+�5
   
   o� $
��Left=�6   $��23��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��772��6a   $��1��6m   .@�5      �� $
��Left=�6   $	��Top=�60   $��26��6H   
�������
�������.��5      �� $1��+/images/chimney-home-icon-transparent-1.png��6   $
��Fill=�6M   $��17��6\   $��18��6h   5      �� 5      -   5        $��Profile��5      $
��Left=�6'   $	��Top=�6B   $	��100��6Z   6f   �� 5      -   5        $��Client requests��5      $
��Left=�6/   $	��Top=�6J   $	��100��6b   6n   �� 5      -   5        $��Requests in progress��5      $
��Left=�64   $	��Top=�6O   $	��120��6g   6s   �� 5      -   5        $��Finished requests��5      $
��Left=�61   $	��Top=�6L   $	��100��6d   6p   5      �� 5   
   $��Choose a repairer��6   $
��Left=�6,   $��	12,38,0,0q�6G   $	��Top=�6Z   $��30(�6r   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_repairers��5      $
��Left=�6)   $	��433��6D   $��
18,156,0,0q�6Q   $	��Top=�6e   $	��757��6}   $��20(�6�      
IsReadOnly . ���	#FFBEEAE26�   �� 5   
   -   5         ��Name$ tb_for_search��5      $
��Left=�6)   $��30��6D   $��	18,93,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��330��6�   $��20(�6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $��
538,93,0,0q�6=   $	��Top=�6Q   $	��130��6i   $��30��6u   $��20(�6�   ���	#FF32BEA66�   �� 5   
   -   5         ��Name$ cb_criteria��5      $
��Left=�6(   $��
363,93,0,0q�6C   $	��Top=�6W   $	��161��6o   $��30��6{   $��20(�6�   .@�5      �� .��6   Name6!   �� 5      .��6   	Surname6$   �� 5      .��6   Email6"   5      �� 5   
   -	   5        $��Forward to repairer��5      $
��Left=�6/   $��300,616,0,0q�6J   $	��Top=�6_   $	��200��6w   $��30��6�   $��20(�6�   ���	#FF32BEA66�   5      5      