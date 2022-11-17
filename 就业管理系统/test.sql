/*
 Navicat Premium Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 50726
 Source Host           : localhost:3306
 Source Schema         : test

 Target Server Type    : MySQL
 Target Server Version : 50726
 File Encoding         : 65001

 Date: 09/11/2022 15:39:07
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('123', '9594B94A209BD8918E18F9EFA8AB9432');

-- ----------------------------
-- Table structure for buyer
-- ----------------------------
DROP TABLE IF EXISTS `buyer`;
CREATE TABLE `buyer`  (
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of buyer
-- ----------------------------
INSERT INTO `buyer` VALUES ('小王', 'dikd3939', '1134384387@qq.com');
INSERT INTO `buyer` VALUES ('小王', 'dikd3939', '1134384387@qq.com');
INSERT INTO `buyer` VALUES ('小王', 'dikd3939', '1134384387@qq.com');

-- ----------------------------
-- Table structure for campany
-- ----------------------------
DROP TABLE IF EXISTS `campany`;
CREATE TABLE `campany`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `campany_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of campany
-- ----------------------------
INSERT INTO `campany` VALUES ('京东', '9594B94A209BD8918E18F9EFA8AB9432', '京东');
INSERT INTO `campany` VALUES ('阿里', '9594B94A209BD8918E18F9EFA8AB9432', '阿里巴巴');
INSERT INTO `campany` VALUES ('华为', '9594B94A209BD8918E18F9EFA8AB9432', '华为');
INSERT INTO `campany` VALUES ('深信服', '9594B94A209BD8918E18F9EFA8AB9432', '深信服');

-- ----------------------------
-- Table structure for campany_info
-- ----------------------------
DROP TABLE IF EXISTS `campany_info`;
CREATE TABLE `campany_info`  (
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `num` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `description` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of campany_info
-- ----------------------------
INSERT INTO `campany_info` VALUES ('京东', '北京', '101', '无');
INSERT INTO `campany_info` VALUES ('阿里巴巴', '杭州', '90', '无');
INSERT INTO `campany_info` VALUES ('华为', '广州、深圳、北京', '200', '只收硕士学历以上');

-- ----------------------------
-- Table structure for chose_list
-- ----------------------------
DROP TABLE IF EXISTS `chose_list`;
CREATE TABLE `chose_list`  (
  `student_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_campany` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `student_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `student_email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `work_position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT ''
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of chose_list
-- ----------------------------
INSERT INTO `chose_list` VALUES ('123', '安全工程师', '京东', '123', '123', '北京', 'allow');
INSERT INTO `chose_list` VALUES ('123', 'GO语言开发工程师', '深信服', '123', '123', '深圳、北京', 'allow');
INSERT INTO `chose_list` VALUES ('222', '嵌入式开发工程师', '华为', '222', '222', '深圳', '');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `status` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT ''
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('123', '9594B94A209BD8918E18F9EFA8AB9432', '123', '123', 'allow');
INSERT INTO `student` VALUES ('222', '847EEA811755E8EF3E47C260795AB4CC', '222', '222', 'allow');

-- ----------------------------
-- Table structure for works
-- ----------------------------
DROP TABLE IF EXISTS `works`;
CREATE TABLE `works`  (
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `campany` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `position` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `num` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `require` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `else` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL,
  `pin` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_unicode_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of works
-- ----------------------------
INSERT INTO `works` VALUES ('安全工程师', '京东', '北京', '100', '本科及以上', '111', '无', '1');
INSERT INTO `works` VALUES ('GO语言开发工程师', '深信服', '深圳、北京', '100', '本科及以上', '222', '无', '2');
INSERT INTO `works` VALUES ('JAVA开发工程师', '阿里巴巴', '杭州', '100', '本科及以上', '333', '无', '3');
INSERT INTO `works` VALUES ('嵌入式开发工程师', '华为', '深圳', '200', '硕士及以上', '444', '211、985', '4');
INSERT INTO `works` VALUES ('CEO', '腾讯', '深圳', '-1', '马化腾', '555', '无', '5');

SET FOREIGN_KEY_CHECKS = 1;
