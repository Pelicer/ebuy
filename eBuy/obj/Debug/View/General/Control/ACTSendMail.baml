   M S B A M L   `   `   `  ����?  ;eBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:eBuy.View.General.ControleBuy.View.General.Control  5   	   +    %eBuy.View.General.Control.ACTSendMail   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:eBuy.View.General.Control     5   	   -   5          �Name$  SendMail��5   	    � Title$ Esqueceu sua senha?��5   	   $	��800��6%   $	��513��62    � 
ResizeMode$ NoResize=�6>    � Icon$* $/eBuy;component/Images/icon/icon.png��6T    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
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
   �� -   5         ��Name$ btnRegister��5#      $�� ��6&   $
��Left=�61   $	��Top=�6L   $��50��6d   $��390,707,0,0q�6o   $��50��6�   #��[  6�   ��6�   Z� ��6�   Z� ��5$      �� 5%      $8 2/eBuy;component/Images/icon/main/success-white.png��6   5'      �� 5(   
   -   5        $ btnBack��5(      $�� ��6"   $
��Left=�6-   $	��Top=�6H   $��50��6`   $��
10,740,0,0q�6k   $��50��6   #��[  6�   ��6�   Z� ��6�   Z� ��5)      �� 5*      $9 3/eBuy;component/Images/icon/main/previous-white.png��6   5,      �� 5-   
   -   5         ��Name$ lblEmail��5-      $��E-Mail:��6"   $
��Left=�64   $	��Top=�6O   $��
23,591,0,0q�6g   
�������$��21.333(�6�   �� 5.   
   -   5         ��Name$ txtEmail��5.      $
��Left=�6$   $��30��6?    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $	��392��6w   $��102,599,0,0q�6�   
�������
�������$��21.333(�6�    � ToolTip$ Seu nome de usuário.��6�    �� SelectionBrush
 �������6�   Z� 6  �� 5/   
   -   5        $ lblText��5/      $D��>Nós lhe enviaremos um email com seu nome de usuário e senha.��6!   $
��Left=�6h   $	��Top=�6�   $��
23,520,0,0q�6�   $	��471��6�   
�������$��16(�6�   �� 50   
   -   5        $
 lblR��50      $��R��6   $
��Left=�6*   $	��Top=�6E   $��64(�6]   $
��Bold"�6k   
�������$��	98,47,0,0q�6�   �� 51   
   -   5        $ 
lbleenviar��51      $��eenviar��6$   $
��Left=�66   $	��Top=�6Q   $��64(�6i   
�������$��
143,47,0,0q�6�   �� 52   
   -	   5        $
 lblS��52      $��S��6   $
��Left=�6*   $	��Top=�6E   $��64(�6]   $
��Bold"�6k   
�������$��202,142,0,0q�6�   �� 53   
   -
   5        $ lblEnha��53      $
��enha��6!   $
��Left=�60   $	��Top=�6K   $��64(�6c   
�������$��237,142,0,0q�6�   55      56      