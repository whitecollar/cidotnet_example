# ansible

Playbook for create user and add ssh key.

Usage:

ansible-playbook InitialUserAndSshKey.yaml  -u %YOUR_REMOTE_USERNAME% --private-key %YOUR_KEYFILE%

hosts - standart inventory file with hosts

ansible.cfg - standart ansible configuration file

InitialUserAndSshKey.yaml - playbook

userlist.yaml - List of user when created (nopass: true - disable sudo passcheck, false - vise-versa)