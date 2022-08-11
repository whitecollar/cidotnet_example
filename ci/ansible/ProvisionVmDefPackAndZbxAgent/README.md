# ansible

Playbook for provisioning VM

Usage:

ansible-playbook ProvisionVmDefPackAndZbxAgent.yaml  -u %YOUR_REMOTE_USERNAME% --private-key %YOUR_KEYFILE%

hosts - standart inventory file with hosts

ansible.cfg - standart ansible configuration file

ProvisionVmDefPackAndZbxAgent.yaml - playbook

packagelist.yaml - List of packages when installed

zabbix-official-repo.gpg - GPG key from repos

zabbix.list - source list for repos