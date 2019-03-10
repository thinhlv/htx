# -*- mode: ruby -*-
# vi: set ft=ruby :

# All Vagrant configuration is done below. The "2" in Vagrant.configure
# configures the configuration version (we support older styles for
# backwards compatibility). Please don't change it unless you know what
# you're doing.
Vagrant.configure("2") do |config|
  config.vm.define "devbox" do |node|
    node.vm.box = "thinhnv/ubuntu-xenial64-devbox"
    node.vm.hostname = "devbox"

    node.vm.provider "virtualbox" do |vb|    
      vb.memory = 1024
      vb.cpus = 2  
      vb.customize ["modifyvm", :id, "--natdnshostresolver1", "on"]
    end

    # ports
    node.vm.network "private_network", ip: "172.16.1.33"

  end
end
