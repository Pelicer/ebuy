   M S B A M L   `   `   `  ����?  ;eBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:eBuy.View.General.ControleBuy.View.General.Control  5   	   +    %eBuy.View.General.Control.ACTMessages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:eBuy.View.General.Control     5   	   -   5          �Name$  Messages��5   	    � Title$ Message��5   	   $	��300��6   $	��700��6&    � Icon$* $/eBuy;component/Images/icon/icon.png��62    � 
ResizeMode$ NoResize=�6^    � WindowStartupLocation$ CenterScreen=�6t    � WindowStyle$
 None=�6�   ���	#FFD34040 � 	Resources 5
         NoHover �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6    .�5      ��  �@�OverridesDefaultStyle	 . 66   �� 5       �@�Cursor$
	 Hand��6'   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $��border��6!   $��1q�6/   
�������#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$		 0.8Q�6<   5      5      5      5      5      .��5      � .+�5    
   �� -   5         ��Name$ lblColor��5       $�� ��6"   $
��Left=�6-   $	��Top=�6H   ���	#FFFFD100$	��700��6w   $��	0,140,0,0q�6�   $	��160��6�   �� 5"   
   -   5         ��Name$ 	imgSucess��5"      $
��Left=�6#   $��50��6>   $	��Top=�6J   $��50��6b   $��
640,10,0,0q�6m    J� RenderTransformOrigin$ 0.5,0.5&�6�   $8��2/eBuy;component/Images/icon/main/success-white.png��6�   $y�Hidden=�6�   z�5#      V� 5$      .~�5%      �� �� 5&       �� AngleY$ 1.404Q�6$   �� 5'      T� 5(       T� Y$ 1.225Q�6)   5)      5+      �� 5,   
   -   5        $ imgError��5,      $
��Left=�6"   $��50��6=   $	��Top=�6I   $��50��6a   $��
640,11,0,0q�6l   $ 0.5,0.5&�6�   $6��0/eBuy;component/Images/icon/main/error-white.png��6�   $y�Hidden=�6�   z�5-      V� 5.      .~�5/      �� �� 50      $ 1.404Q�6$   �� 51      T� 52      $ 1.225Q�6)   53      55      �� 56   
   -   5        $ imgInformation��56      $
��Left=�6(   $��50��6C   $	��Top=�6O   $��50��6g   $��
640,10,0,0q�6r   $ 0.5,0.5&�6�   $5��//eBuy;component/Images/icon/main/info-white.png��6�   $y�Hidden=�6�   z�57      V� 58      .~�59      �� �� 5:      $ 1.404Q�6$   �� 5;      T� 5<      $ 1.225Q�6)   5=      5?      �� 5@   
   -   5         ��Name$ btnOK��5@      $��OK��6    $
��Left=�6-   $	��Top=�6H   $	��132��6`   $��275,247,0,0q�6l   $��34��6�   
�������
�������$��21.333(�6�   #��[  6�   ��6�   Z� 6�   �� 5A   
   -   5        $ lblTitle��5A      $��Título��6"   $
��Left=�63   $	��Top=�6N   $��26.667(�6f   
�������$	��680��6�   $��58��6�   $��	10,10,0,0q�6�   ��6�   Z� 6�   �� 5B   
   -   5        $ 
lblMessage��5B      $�� ��6$   $
��Left=�6/   $	��Top=�6J   $	��614��6b   $��	10,86,0,0q�6n   
�������$ 0.373,0.231&�6�   $	��124��6�   
���   �$��21.333(�6�   
���   �$��2q�6�   �� 5C   
   -	   5        $
 img1��5C      $
��Left=�6   $	��162��69   $	��Top=�6F   $	��142��6^   $��
558,55,0,0q�6j   $2��,/eBuy;component/Images/icon/characters/1.png��6~   $y�Hidden=�6�   �� 5D   
   -
   5        $
 img2��5D      $
��Left=�6   $	��162��69   $	��Top=�6F   $	��142��6^   $��
558,48,0,0q�6j   $2��,/eBuy;component/Images/icon/characters/2.png��6~   $y�Hidden=�6�   �� 5E   
   -   5        $
 img3��5E      $
��Left=�6   $	��162��69   $	��Top=�6F   $	��142��6^   $��
558,48,0,0q�6j   $2��,/eBuy;component/Images/icon/characters/3.png��6~   $y�Hidden=�6�   �� 5F   
   -   5        $
 img4��5F      $
��Left=�6   $	��162��69   $	��Top=�6F   $	��142��6^   $��
558,48,0,0q�6j   $2��,/eBuy;component/Images/icon/characters/4.png��6~   $y�Hidden=�6�   5H      5I      