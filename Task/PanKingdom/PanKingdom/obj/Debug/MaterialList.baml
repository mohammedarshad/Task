   M S B A M L   `   `   `  ����E  APanKingdom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PanKingdom
PanKingdom  5   	       PanKingdom.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PanKingdom     5   	     � Title$  MaterialList��5   	   $��363.652��6   $��749.645��6/   
�������.��5	      � $��0,0,-37,-265q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��Code:��6   $
��Left=�6/   $	��Top=�6J   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>    �� TextWrapping$
 Wrap=�6J   $	��Top=�6^   $	��120��6v   $��82,4,0,0q�6�   �� 5   
   -   5        $ label1��5      $��
Unit Type:��6    $
��Left=�65   $	��Top=�6P   $��	238,1,0,0q�6h   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��	307,5,0,0q�6�   �� 5   
   -   5        $ label2��5      $��	Category:��6    $
��Left=�64   $	��Top=�6O   $��	505,4,0,0q�6g   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��	598,3,0,0q�6�   �� 5   
   -   5        $ label3��5      $��Description:��6    $
��Left=�67   $	��Top=�6R   $��0,55,0,0q�6j   $��83��6|   �� 5   
   -   5        $ textBox3��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��636��6w   $��	82,58,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        $��materiallist��5         AutoGenerateColumns .  $��10,142,61,322q�6C   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Material Code��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Name+6U     5      $ Material Description��6%   $	 200 6\    6C   �� *Name+6\     5      $ 	Unit Type��6%   $	 200 6Q    68   �� *Name+6Q     5      $ Category��6%   $	 200 6P    67   �� *Name+6P   5      �� 5   
   -
   5        	 ��Name$	 btnadd��5      $	��ADD��6!   $
��Left=�6/   $	��Top=�6J   $��75��6b   $��196,281,0,0q�6m   
�������6�   �� 5    
   -   5        $	 btndel��5       $��Delete��6!   $��Right=�62   $	��Top=�6N   $��75��6f   $��0,281,322,0q�6q   
�������6�   �� 5"   
   -   5        $	 btnedit��5"      $
��Edit��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��288,281,0,0q�6o   
�������6�   �� 5$   
   -   5        $	 btnclose��5$      $��Close��6#   $��Right=�63   $	��Top=�6O   $��75��6g   $��0,281,231,0q�6r   
�������6�   5%      5&      