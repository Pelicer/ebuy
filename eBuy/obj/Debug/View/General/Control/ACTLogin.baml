   M S B A M L   `   `   `  ����?  ;eBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:eBuy.View.General.ControleBuy.View.General.Control  5   	   (    "eBuy.View.General.Control.ACTLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:eBuy.View.General.Control     5   	   -   5          �Name$  Login��5   	    � Title$ Login��5   	   $	��800��6   $	��513��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F    � Icon$* $/eBuy;component/Images/icon/icon.png��6k    � WindowStyle$
 None=�6�   ��5	      �� 5
   
    �� ImageSource$0 */eBuy;component/Images/wallpaper/login.jpg��6    � 	Resources 5         NoHover �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6    .�5      �� 	 �@�OverridesDefaultStyle
 . 66   �� 5      	 �@�Cursor$

 Hand��6'   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� 	 �@J�Opacity$	
 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5#   
   �� -   5         ��Name$ lblUser��5#      $��	Usuário:��6!   $
��Left=�64   $	��Top=�6O   $��100,510,0,0q�6g   
�������$��21.333(�6�   �� 5$   
   -   5        $ lblPassword��5$      $��Senha:��6%   $
��Left=�66   $	��Top=�6Q   $��100,553,0,0q�6i   
�������$��21.333(�6�   �� 5%   
   -   5         ��Name$ txtUser��5%      $
��Left=�6$   $��30��6?    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $	��230��6w   $��198,518,0,0q�6�   
�������
�������$��21.333(�6�    � ToolTip$ Seu nome de usuário.��6�    �� SelectionBrush
 �������6�   Z� 6  G� 5&   
   -   5         G�Name$ psbPassword��5&      $
��Left=�6+   $	��Top=�6F   $	��230��6^   $��198,561,0,0q�6j   $��30��6   
�������
������� G� SelectionBrush
 �����$ Sua senha de login.��6�   $��21.333(�6�   ��6�   Z� 6�   �� 5'   
   -   5        $
 lblE��5'      $��e��6   $
��Left=�6*   $	��Top=�6E   $��170,102,0,0q�6]   $��64(�6r   
�������$
��Bold"�6�   �� 5(   
   -   5        $ lblBuy��5(      $	��Buy��6    $
��Left=�6.   $	��Top=�6I   $��208,102,0,0q�6a   $��64(�6v   
�������6�   �� 5)   
   -   5         ��Name$ btnLogin��5)      $�� ��6#   $
��Left=�6.   $	��Top=�6I   $��50��6a   $��213,621,0,0q�6l   $��50��6�   #��[  6�   ��6�   Z� ��6�   Z� ��5*      �� 5+      $8 2/eBuy;component/Images/icon/main/success-white.png��6   5-      �� 5.   
   -	   5        $ 	btnCancel��5.      $�� ��6$   $
��Left=�6/   $	��Top=�6J   $��50��6b   $��268,621,0,0q�6m   $��50��6�   #��[  6�   ��6�   Z� ��6�   Z� ��5/      �� 50      $6 0/eBuy;component/Images/icon/main/error-white.png��6   52      �� 53   
   -
   5        $ lblRegister��53      $��Cadastrar novo usuário.��6%   $
��Left=�6G   $	��Top=�6b   $��
10,737,0,0q�6z   
�������$��16(�6�   6�   �� 54   
   -   5        $ lblSenha��54      $(��"Clique aqui se esqueceu sua senha.��6"   $
��Left=�6O   $	��Top=�6j   $��
10,759,0,0q�6�   
�������$��16(�6�   $	��293��6�   6�   56      57      